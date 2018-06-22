//
//------------------< k e r n e l s . c >---------------------
//

#include "config.h"
#include "data_types.h"
#include "random_mwc.h"
#include "variations.h"

#define AccumPtr(x,y,sub_x,sub_y) (accumBuffer + 4*(((y)*xRes) + (x)) + 2*(sub_y) + (sub_x))
#define AccumRef(x,y,sub_x,sub_y) (*(AccumPtr((x),(y),(sub_x),(sub_y))))

#define OutputPtr(x,y) (outputBuffer + ((y)*xRes) + (x))
#define OutputRef(x,y) (*(OutputPtr((x),(y))))

#ifdef _CUDA_SRC_
CONST_MEM    FractalInfo      fractalInfo[1];
CONST_MEM    BranchInfo       branchInfo[MaxBranches];
CONST_MEM    float            variWeightBuffer[MaxBranches*MaxVariations];

texture<float4, 2, cudaReadModeElementType> paletteTex;
#endif

KERNEL void init_iterators_kernel(
	GLOBAL_MEM uint4 entropyXBuffer[],
	GLOBAL_MEM uint  entropyCBuffer[],
	GLOBAL_MEM uint  entropySeedBuffer[]
){
	LOCAL_MEM uint4 randXBuffer   [IterGroupSize];
	LOCAL_MEM uint  randCBuffer   [IterGroupSize];
	LOCAL_MEM uint  randSeedBuffer[IterGroupSize];
	
	uint lid = LOCAL_ID_X;
	uint gid = GLOBAL_ID_X;
	
	randXBuffer[lid]    = make_uint4(0,0,0,0);
	randCBuffer[lid]    = 0;
	randSeedBuffer[lid] = entropySeedBuffer[gid];
	
	MWC_seed(randXBuffer+lid, randCBuffer+lid, randSeedBuffer[lid]);
	
	entropyXBuffer[gid] = randXBuffer[lid];
	entropyCBuffer[gid] = randCBuffer[lid];
}

KERNEL void reset_iterators_kernel(
	             uint             xRes,
	             uint             yRes,
#ifdef _OPENCL_SRC_
	CONST_MEM    FractalInfo*     fractalInfo,
	CONST_MEM    BranchInfo       branchInfo[],
	CONST_MEM    float            variWeightBuffer[],
#endif
	GLOBAL_MEM   float2           iterPosStateBuffer[],
	GLOBAL_MEM   float2           iterColorStateBuffer[],
	GLOBAL_MEM   IterStatEntry    iterStatBuffer[],
	GLOBAL_MEM   GlobalStatEntry* globalStatBuffer,
	GLOBAL_MEM   uint4            entropyXBuffer[],
	GLOBAL_MEM   uint             entropyCBuffer[],
	GLOBAL_MEM   uint             entropySeedBuffer[]
){
	int iter;
	uint bi;
	float2 pos;
	float2 color;
	uint rnd;

	LOCAL_MEM uint4 randXBuffer   [IterGroupSize];
	LOCAL_MEM uint  randCBuffer   [IterGroupSize];
	LOCAL_MEM uint  randSeedBuffer[IterGroupSize];
	
	uint lid = LOCAL_ID_X;
	uint gid = GLOBAL_ID_X;
	
	randXBuffer[lid]    = make_uint4(0,0,0,0);
	randCBuffer[lid]    = 0;
	randSeedBuffer[lid] = entropySeedBuffer[gid];
	
	MWC_seed(randXBuffer+lid, randCBuffer+lid, randSeedBuffer[lid]);
	
	pos = MWC_rand_float2(randXBuffer+lid, randCBuffer+lid);
	//rndf = (float)(MWC_rand(randXBuffer+lid, randCBuffer+lid) & 0x000FFFFF) / 1048575.0f;
	//pos.x = 2.0f*rndf - 1.0f;
	//rndf = (float)(MWC_rand(randXBuffer+lid, randCBuffer+lid) & 0x000FFFFF) / 1048575.0f;
	//pos.y = 2.0f*rndf - 1.0f;
	color = make_float2(0.5f, 0.5f);
	
	for(iter = 0; iter < WarmupIterationCount; iter++)
	{
		rnd = MWC_rand(randXBuffer+lid, randCBuffer+lid);
		bi = chooseRandomBranch(rnd & 0x0000FFFF, fractalInfo->branchCount, branchInfo);                //the low entropy bits are for branch selection
		iterate(&pos, &color, (rnd>>16), branchInfo+bi, variWeightBuffer+(bi*MaxVariations), randXBuffer+lid, randCBuffer+lid); //the extra entropy bits are for variations
	}
	
	iterPosStateBuffer[gid] = pos;
	iterColorStateBuffer[gid] = color;
	iterStatBuffer[gid].dotCount = 0;
	iterStatBuffer[gid].peakDensity = 0.0f;
	
	if(gid == 0) //the first thread will update the total iteration count
	{
		globalStatBuffer->iterCount =     0;
		globalStatBuffer->dotCount =      0;
		globalStatBuffer->density  =      0.0f;
		globalStatBuffer->peakDensity =   0.0f;
		globalStatBuffer->scaleConstant = 0.0f;
	}
}

KERNEL void reset_output_kernel(
	int xRes,
	int yRes,
	GLOBAL_MEM float4  accumBuffer[],
	GLOBAL_MEM uint    outputBuffer[]
)
{
	int x = GLOBAL_ID_X;
	int y = GLOBAL_ID_Y;

	if(x < xRes && y < yRes)
	{
		AccumRef(x,y,0,0) = make_float4(0.0f, 0.0f, 0.0f, 0.0f);
		AccumRef(x,y,0,1) = make_float4(0.0f, 0.0f, 0.0f, 0.0f);
		AccumRef(x,y,1,0) = make_float4(0.0f, 0.0f, 0.0f, 0.0f);
		AccumRef(x,y,1,1) = make_float4(0.0f, 0.0f, 0.0f, 0.0f);
		
		OutputRef(x,y) = 0x00000000;
	}
}

#ifdef _OPENCL_SRC_
#ifdef _LOW_PROFILE_
DEVICE float4 samplePaletteBuffer(float2 v, GLOBAL_PARAM uchar4 paletteBuffer[], uint width, uint height)
{
	int x = clamp((int)(v.x * (float)width), 0, (int)width-1);
	int y = clamp((int)(v.y * (float)height), 0, (int)height-1);
	uchar4 pix = paletteBuffer[y*width+x];
	return make_float4((float)pix.x / 255.0f, (float)pix.y / 255.0f, (float)pix.z / 255.0f, (float)pix.w / 255.0f);
}
#endif
#endif


KERNEL void iterate_kernel(
	             uint             xRes,
	             uint             yRes,
#ifdef _OPENCL_SRC_
	CONST_MEM    FractalInfo*     fractalInfo,
	CONST_MEM    BranchInfo       branchInfo[],
	CONST_MEM    float            variWeightBuffer[],
#endif
	GLOBAL_MEM   float2           iterPosStateBuffer[],
	GLOBAL_MEM   float2           iterColorStateBuffer[],
	GLOBAL_MEM   IterStatEntry    iterStatBuffer[],
	GLOBAL_MEM   GlobalStatEntry* globalStatBuffer,
	GLOBAL_MEM   uint4            entropyXBuffer[],
	GLOBAL_MEM   uint             entropyCBuffer[],
	GLOBAL_MEM   float4           accumBuffer[],
#ifdef _OPENCL_SRC_
#ifdef _LOW_PROFILE_
                 uint             paletteWidth,
                 uint             paletteHeight,
	GLOBAL_MEM   uchar4           paletteBuffer[],
#else
	__read_only  image2d_t        palette,
	             sampler_t        paletteSampler,
#endif
#endif
	             uint             iterCount
){
	float2 pos;
	float2 color;
	float4 sample = make_float4(1.0f,1.0f,1.0f,1.0f);
	
	float4 mem;
	uint bi;
	float2 screenPos;
	UInt64 dotCount;
	float peakDensity;
	int xa,ya;
	int x,y;
	uint iter;
	uint rnd;
		
	LOCAL_MEM uint4 randXBuffer   [IterGroupSize];
	LOCAL_MEM uint  randCBuffer   [IterGroupSize];
	
	uint lid = LOCAL_ID_X;
	uint gid = GLOBAL_ID_X;

	pos =       iterPosStateBuffer[gid];
	color =     iterColorStateBuffer[gid];
	dotCount =  iterStatBuffer[gid].dotCount;
	peakDensity = iterStatBuffer[gid].peakDensity;
	randXBuffer[lid] = entropyXBuffer[gid];
	randCBuffer[lid] = entropyCBuffer[gid];
	
	
	for(iter = 0; iter < iterCount; iter++)
	{
		rnd = MWC_rand(randXBuffer+lid, randCBuffer+lid);
		bi = chooseRandomBranch(rnd & 0x0000FFFF, fractalInfo->branchCount, branchInfo);                  //the low entropy bits are for branch selection
		
		iterate(&pos, &color, (rnd>>16), branchInfo+bi, variWeightBuffer+(bi*MaxVariations), randXBuffer+lid, randCBuffer+lid); //the extra entropy bits are for variations
		
		screenPos = Affine2D_transformVector_cm(&(fractalInfo->vpsTransform), pos);
		
		xa = (int)(2.0f*screenPos.x);
		ya = (int)(2.0f*screenPos.y);
		x  = xa >> 1;
		y  = ya >> 1;
		
		if(x >= 0 && x < xRes && y >= 0 && y < yRes)
		{
#ifdef _OPENCL_SRC_
#ifdef _LOW_PROFILE_
			sample = samplePaletteBuffer(color, paletteBuffer, paletteWidth, paletteHeight);
#else
			sample = read_imagef(palette, paletteSampler, color);
#endif
#endif
#ifdef _CUDA_SRC_
			sample = tex2D(paletteTex, color.x, color.y);
#endif
			//accumulate the histogram buffer
			//this is not actually thread safe, but hopefully it wont screw up the counts
			//enough to trash the image
			mem = AccumRef(x,y,(xa&1),(ya&1));
			mem.x += sample.x;
			mem.y += sample.y;
			mem.z += sample.z;
			mem.w += 1.0f;
			AccumRef(x,y,(xa&1),(ya&1)) = mem;
			
			dotCount++;
			peakDensity = math_fmax(peakDensity, mem.w);
		}
	}
	
	
	iterPosStateBuffer[gid]   = pos;
	iterColorStateBuffer[gid] = color;
	iterStatBuffer[gid].dotCount = dotCount;
	iterStatBuffer[gid].peakDensity = peakDensity;
	entropyXBuffer[gid] = randXBuffer[lid];
	entropyCBuffer[gid] = randCBuffer[lid];
	
	if(gid == 0)
	{
		globalStatBuffer->iterCount += (UInt64)(GLOBAL_SIZE_X * iterCount);
	}
}


KERNEL void update_stats_kernel(
                 uint             xRes,
                 uint             yRes,
#ifdef _OPENCL_SRC_
	CONST_MEM    FractalInfo*     fractalInfo,
#endif
                 uint             iteratorCount,
	GLOBAL_MEM   IterStatEntry    iterStatBuffer[],
	GLOBAL_MEM   GlobalStatEntry* globalStatBuffer 
){
	UInt64 totalIterationCount = 0;
	UInt64 totalDotCount = 0;
	float peakDensity = 0.0f;
	int i;
	float totalSubPixels, density, invPixArea, scaleConstant;
	
	if(GLOBAL_ID_X == 0)
	{
		for(i = 0; i < iteratorCount; i++)
		{
			totalDotCount += iterStatBuffer[i].dotCount;
			peakDensity = math_fmax(peakDensity, iterStatBuffer[i].peakDensity);
		}
		totalIterationCount = globalStatBuffer->iterCount;
		totalSubPixels = (float)(xRes*yRes*SubPixelCount);
		density = (float)totalDotCount / totalSubPixels;
		invPixArea = math_fabs((fractalInfo->vpsTransform.xa.x)*(fractalInfo->vpsTransform.ya.y) - (fractalInfo->vpsTransform.xa.y)*(fractalInfo->vpsTransform.ya.x));
		scaleConstant = Tone_C2*(invPixArea*(float)SubPixelCount)/(float)totalIterationCount;
		
		globalStatBuffer->dotCount = totalDotCount;
		globalStatBuffer->density = math_fmax(density, Epsilon);
		globalStatBuffer->peakDensity = math_fmax(peakDensity, Epsilon);
		globalStatBuffer->scaleConstant = math_fmax(scaleConstant, Epsilon);
	}
}

DEVICE float4 tonemap(CONST_PARAM FractalInfo* fractal, float4 rawPix, float scaleConstant)
{
	float z, ka, gammaFactor;
	float4 logPix;
	float4 result;        //the tonemapped pixel
	
	if(rawPix.w <= 0.5) //bail if alpha is too small to avoid dividing by zero
		return make_float4(0.0f, 0.0f, 0.0f, 0.0f);
	
	logPix.w = Tone_C1 * fractal->brightness * fast_log10(1.0f+rawPix.w*scaleConstant);
	ka = logPix.w / rawPix.w;
	
	logPix.x = ka * rawPix.x;
	logPix.y = ka * rawPix.y;
	logPix.z = ka * rawPix.z;
	
	z = fast_pow(logPix.w,fractal->invGamma);
	gammaFactor = z / logPix.w;
	
	result.x = fast_saturate(lerp(fast_pow(logPix.x,fractal->invGamma), gammaFactor*logPix.x, fractal->vibrancy));
	result.y = fast_saturate(lerp(fast_pow(logPix.y,fractal->invGamma), gammaFactor*logPix.y, fractal->vibrancy));
	result.z = fast_saturate(lerp(fast_pow(logPix.z,fractal->invGamma), gammaFactor*logPix.z, fractal->vibrancy));
	result.w = fast_saturate(z);
	
	return result;
}

KERNEL void update_output_kernel(
	           uint             xRes,
	           uint             yRes,
#ifdef _OPENCL_SRC_
	CONST_MEM  FractalInfo*     fractalInfo,
#endif
	GLOBAL_MEM GlobalStatEntry* globalStatBuffer,
	GLOBAL_MEM float4           accumBuffer[],
	GLOBAL_MEM uint             outputBuffer[]
){
	uint4 iPix;
	float4 pix,acc;
	float scaleConstant;
	
	int x = GLOBAL_ID_X;
	int y = GLOBAL_ID_Y;
	
	acc = make_float4(0.0f, 0.0f, 0.0f, 0.0f);
		
	if(x < xRes && y < yRes)
	{
		scaleConstant = globalStatBuffer->scaleConstant;
		
		pix = tonemap( fractalInfo, AccumRef(x,y,0,0), scaleConstant);
		acc.x += pix.w*pix.x;
		acc.y += pix.w*pix.y;
		acc.z += pix.w*pix.z;
		acc.w += pix.w;
			
		pix = tonemap( fractalInfo, AccumRef(x,y,0,1), scaleConstant);
		acc.x += pix.w*pix.x;
		acc.y += pix.w*pix.y;
		acc.z += pix.w*pix.z;
		acc.w += pix.w;
		
		pix = tonemap( fractalInfo, AccumRef(x,y,1,0), scaleConstant);
		acc.x += pix.w*pix.x;
		acc.y += pix.w*pix.y;
		acc.z += pix.w*pix.z;
		acc.w += pix.w;
		
		pix = tonemap( fractalInfo, AccumRef(x,y,1,1), scaleConstant);
		acc.x += pix.w*pix.x;
		acc.y += pix.w*pix.y;
		acc.z += pix.w*pix.z;
		acc.w += pix.w;
		
		if(acc.w < (1.0f/256.0f))
		{
			iPix = make_uint4(0,0,0,0);
		}
		else
		{
			acc.x /= acc.w;
			acc.y /= acc.w;
			acc.z /= acc.w;
			acc.w *= 0.25f;
					
			iPix.x = (uint)(255.0f*acc.x) & 0xFF;
			iPix.y = (uint)(255.0f*acc.y) & 0xFF;
			iPix.z = (uint)(255.0f*acc.z) & 0xFF;
			iPix.w = (uint)(255.0f*acc.w) & 0xFF;
		}
				
		OutputRef(x,y) = iPix.w << 24 | iPix.z << 16 | iPix.y << 8 | iPix.x;
	}
}
/*
 //old tonemapping
DEVICE float4 tonemap(CONST_PARAM FractalInfo* fractal, float4 rawPix, float scaleConstant)
{
	float z, gammaFactor;
	float4 logPix;
	float4 result;        //the tonemapped pixel
	
	float ka = Tone_C1 * fractal->brightness * fast_log10(1.0f+rawPix.w*scaleConstant) / rawPix.w;
		
	logPix.x = rawPix.x*ka;
	logPix.y = rawPix.y*ka;
	logPix.z = rawPix.z*ka;
	logPix.w = rawPix.w*ka;
	
	z = fast_pow(logPix.w,fractal->invGamma);
	gammaFactor = z / logPix.w;
	
	result.x = fast_saturate(lerp(fast_pow(logPix.x,fractal->invGamma), gammaFactor*logPix.x, fractal->vibrancy));
	result.y = fast_saturate(lerp(fast_pow(logPix.y,fractal->invGamma), gammaFactor*logPix.y, fractal->vibrancy));
	result.z = fast_saturate(lerp(fast_pow(logPix.z,fractal->invGamma), gammaFactor*logPix.z, fractal->vibrancy));
	result.w = fast_saturate(z);
	
	return result;
}

KERNEL void update_output_kernel(
	           uint             xRes,
	           uint             yRes,
#ifdef _OPENCL_SRC_
	CONST_MEM  FractalInfo*     fractalInfo,
#endif
	GLOBAL_MEM GlobalStatEntry* globalStatBuffer,
	GLOBAL_MEM float4           accumBuffer[],
	GLOBAL_MEM uint             outputBuffer[]
){
	uint4 iPix;
	float4 pix,acc;
	float scaleConstant;
	
	int x = GLOBAL_ID_X;
	int y = GLOBAL_ID_Y;
		
	if(x < xRes && y < yRes)
	{
		scaleConstant = globalStatBuffer->scaleConstant;
		
		acc = tonemap( fractalInfo, AccumRef(x,y,0,0), scaleConstant);
			
		pix = tonemap( fractalInfo, AccumRef(x,y,0,1), scaleConstant);
		acc.x += pix.x; acc.y += pix.y; acc.z += pix.z; acc.w += pix.w;
		
		pix = tonemap( fractalInfo, AccumRef(x,y,1,0), scaleConstant);
		acc.x += pix.x; acc.y += pix.y; acc.z += pix.z; acc.w += pix.w;
		
		pix = tonemap( fractalInfo, AccumRef(x,y,1,1), scaleConstant);
		acc.x += pix.x; acc.y += pix.y; acc.z += pix.z; acc.w += pix.w;
		
		acc.x /= 4.0f;
		acc.y /= 4.0f;
		acc.z /= 4.0f;
		acc.w /= 4.0f;
				
		iPix.x = (uint)(255.0f*acc.x);
		iPix.y = (uint)(255.0f*acc.y);
		iPix.z = (uint)(255.0f*acc.z);
		iPix.w = (uint)(255.0f*acc.w);
				
		OutputRef(x,y) = iPix.w << 24 | iPix.z << 16 | iPix.y << 8 | iPix.x;
	}
}

*/

/* Experimental version
DEVICE float4 tonemap(CONST_PARAM FractalInfo* fractal, float4 rawPix, float scaleConstant)
{
	float z;
	float4 logPix;
	float4 result;        //the tonemapped pixel
	
	if(rawPix.w <= Epsilon)
		return make_float4(0.0f, 0.0f, 0.0f, 0.0f);
	
	logPix.w = Tone_C1 * fractal->brightness * fast_log10(1.0f+rawPix.w*scaleConstant);
	
	logPix.x = fractal->brightness * rawPix.x / rawPix.w;
	logPix.y = fractal->brightness * rawPix.y / rawPix.w;
	logPix.z = fractal->brightness * rawPix.z / rawPix.w;
	
	z = fast_pow(logPix.w,fractal->invGamma);
	
	result.x = fast_saturate(lerp(fast_pow(logPix.x,fractal->invGamma), logPix.x, fractal->vibrancy));
	result.y = fast_saturate(lerp(fast_pow(logPix.y,fractal->invGamma), logPix.y, fractal->vibrancy));
	result.z = fast_saturate(lerp(fast_pow(logPix.z,fractal->invGamma), logPix.z, fractal->vibrancy));
	result.w = fast_saturate(z);
	
	return result;
}
*/
