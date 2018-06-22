namespace Fractron9000.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFlameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFractronFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.invertBranchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.prevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.toggleEditorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewGenomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runDiagnosticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paletteMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.load1DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renderContainer = new System.Windows.Forms.Panel();
			this.engineStatusPanel = new System.Windows.Forms.Panel();
			this.restartEngineButton = new System.Windows.Forms.Button();
			this.viewEngineErrorButton = new System.Windows.Forms.Button();
			this.engineStatusLabel = new System.Windows.Forms.Label();
			this.renderer = new Fractron9000.UI.RenderControl();
			this.savePanel = new System.Windows.Forms.Panel();
			this.saveButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.localizedCheckbox = new System.Windows.Forms.CheckBox();
			this.backgroundColorPanel = new System.Windows.Forms.Panel();
			this.libraryNameLabel = new System.Windows.Forms.Label();
			this.libraryView = new System.Windows.Forms.ListView();
			this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.libraryItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.moveToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brightnessSpinner = new MTUtil.UI.DragSpin();
			this.gammaSpinner = new MTUtil.UI.DragSpin();
			this.vibrancySpinner = new MTUtil.UI.DragSpin();
			this.weightSpinner = new MTUtil.UI.DragSpin();
			this.colorWeightSpinner = new MTUtil.UI.DragSpin();
			this.chromaControl = new Fractron9000.UI.ChromaControl();
			this.sideBar = new System.Windows.Forms.TabControl();
			this.parametersPage = new System.Windows.Forms.TabPage();
			this.variGroupBox = new System.Windows.Forms.GroupBox();
			this.toneGroupBox = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.colorGroupBox = new System.Windows.Forms.GroupBox();
			this.colorWeightLabel = new System.Windows.Forms.Label();
			this.weightLabel = new System.Windows.Forms.Label();
			this.libraryPage = new System.Windows.Forms.TabPage();
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.zoomInToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.zoomOutToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.flipVerticalToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.viewPreviousToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.viewNextToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toggleEditorToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.addBranchToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.removeBranchToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.duplicateBranchToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.invertBranchToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.topPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.divPanel2 = new System.Windows.Forms.Panel();
			this.statusStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.paletteMenu.SuspendLayout();
			this.renderContainer.SuspendLayout();
			this.engineStatusPanel.SuspendLayout();
			this.savePanel.SuspendLayout();
			this.libraryItemMenu.SuspendLayout();
			this.sideBar.SuspendLayout();
			this.parametersPage.SuspendLayout();
			this.variGroupBox.SuspendLayout();
			this.toneGroupBox.SuspendLayout();
			this.colorGroupBox.SuspendLayout();
			this.libraryPage.SuspendLayout();
			this.mainToolStrip.SuspendLayout();
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 540);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(801, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "status area";
			// 
			// mainStatusLabel
			// 
			this.mainStatusLabel.BackColor = System.Drawing.SystemColors.Control;
			this.mainStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mainStatusLabel.Name = "mainStatusLabel";
			this.mainStatusLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.mainStatusLabel.Size = new System.Drawing.Size(12, 17);
			this.mainStatusLabel.Text = "-";
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(172, 25);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "Main Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFlameToolStripMenuItem,
            this.openFractronFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveLibraryToolStripMenuItem,
            this.saveAsImageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.newIcon;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openFlameToolStripMenuItem
			// 
			this.openFlameToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.openIcon;
			this.openFlameToolStripMenuItem.Name = "openFlameToolStripMenuItem";
			this.openFlameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFlameToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.openFlameToolStripMenuItem.Text = "Open Library...";
			this.openFlameToolStripMenuItem.Click += new System.EventHandler(this.openLibraryToolStripMenuItem_Click);
			// 
			// openFractronFileToolStripMenuItem
			// 
			this.openFractronFileToolStripMenuItem.Name = "openFractronFileToolStripMenuItem";
			this.openFractronFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.openFractronFileToolStripMenuItem.Text = "Open Fractron File...";
			this.openFractronFileToolStripMenuItem.Click += new System.EventHandler(this.openFractronFileToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.saveIcon;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.saveToolStripMenuItem.Text = "&Save Fractal";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveLibraryToolStripMenuItem
			// 
			this.saveLibraryToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.saveAllIcon;
			this.saveLibraryToolStripMenuItem.Name = "saveLibraryToolStripMenuItem";
			this.saveLibraryToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.saveLibraryToolStripMenuItem.Text = "Save Library As...";
			this.saveLibraryToolStripMenuItem.Click += new System.EventHandler(this.saveLibraryToolStripMenuItem_Click);
			// 
			// saveAsImageToolStripMenuItem
			// 
			this.saveAsImageToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.saveAsImageIcon;
			this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
			this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.saveAsImageToolStripMenuItem.Text = "Save As Image...";
			this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBranchToolStripMenuItem,
            this.removeBranchToolStripMenuItem,
            this.duplicateBranchToolStripMenuItem,
            this.invertBranchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// addBranchToolStripMenuItem
			// 
			this.addBranchToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.addBranchIcon;
			this.addBranchToolStripMenuItem.Name = "addBranchToolStripMenuItem";
			this.addBranchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
			this.addBranchToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.addBranchToolStripMenuItem.Text = "&Add Branch";
			this.addBranchToolStripMenuItem.Click += new System.EventHandler(this.addBranchToolStripMenuItem_Click);
			// 
			// removeBranchToolStripMenuItem
			// 
			this.removeBranchToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.removeBranchIcon;
			this.removeBranchToolStripMenuItem.Name = "removeBranchToolStripMenuItem";
			this.removeBranchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.removeBranchToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.removeBranchToolStripMenuItem.Text = "&Remove Branch";
			this.removeBranchToolStripMenuItem.Click += new System.EventHandler(this.removeBranchToolStripMenuItem_Click);
			// 
			// duplicateBranchToolStripMenuItem
			// 
			this.duplicateBranchToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.duplicateBranchIcon;
			this.duplicateBranchToolStripMenuItem.Name = "duplicateBranchToolStripMenuItem";
			this.duplicateBranchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.duplicateBranchToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.duplicateBranchToolStripMenuItem.Text = "&Duplicate Branch";
			this.duplicateBranchToolStripMenuItem.Click += new System.EventHandler(this.duplicateBranchToolStripMenuItem_Click);
			// 
			// invertBranchToolStripMenuItem
			// 
			this.invertBranchToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.invertBranchIcon;
			this.invertBranchToolStripMenuItem.Name = "invertBranchToolStripMenuItem";
			this.invertBranchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.invertBranchToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.invertBranchToolStripMenuItem.Text = "In&vert Branch";
			this.invertBranchToolStripMenuItem.Click += new System.EventHandler(this.invertBranchToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.configIcon;
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.configToolStripMenuItem.Text = "&Configuration...";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.resetViewToolStripMenuItem,
            this.toolStripMenuItem3,
            this.prevToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toggleEditorsToolStripMenuItem,
            this.viewGenomeToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.zoomInIcon;
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.zoomInToolStripMenuItem.Text = "Zoom &In";
			this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
			// 
			// zoomOutToolStripMenuItem
			// 
			this.zoomOutToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.zoomOutIcon;
			this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
			this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
			this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
			// 
			// flipToolStripMenuItem
			// 
			this.flipToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.flipVerticalIcon;
			this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
			this.flipToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.flipToolStripMenuItem.Text = "&Flip Vertical";
			this.flipToolStripMenuItem.Click += new System.EventHandler(this.flipVerticalToolStripMenuItem_Click);
			// 
			// resetViewToolStripMenuItem
			// 
			this.resetViewToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.resetViewIcon;
			this.resetViewToolStripMenuItem.Name = "resetViewToolStripMenuItem";
			this.resetViewToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.resetViewToolStripMenuItem.Text = "&Reset View";
			this.resetViewToolStripMenuItem.Click += new System.EventHandler(this.resetViewToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
			// 
			// prevToolStripMenuItem
			// 
			this.prevToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.viewPrevIcon;
			this.prevToolStripMenuItem.Name = "prevToolStripMenuItem";
			this.prevToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
			this.prevToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.prevToolStripMenuItem.Text = "View Prev";
			this.prevToolStripMenuItem.Click += new System.EventHandler(this.prevToolStripMenuItem_Click);
			// 
			// nextToolStripMenuItem
			// 
			this.nextToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.viewNextIcon;
			this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
			this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
			this.nextToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.nextToolStripMenuItem.Text = "View Next";
			this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(191, 6);
			// 
			// toggleEditorsToolStripMenuItem
			// 
			this.toggleEditorsToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.viewEditorIcon;
			this.toggleEditorsToolStripMenuItem.Name = "toggleEditorsToolStripMenuItem";
			this.toggleEditorsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.toggleEditorsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.toggleEditorsToolStripMenuItem.Text = "Toggle Editor";
			this.toggleEditorsToolStripMenuItem.Click += new System.EventHandler(this.toggleEditorsToolStripMenuItem_Click);
			// 
			// viewGenomeToolStripMenuItem
			// 
			this.viewGenomeToolStripMenuItem.Name = "viewGenomeToolStripMenuItem";
			this.viewGenomeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.viewGenomeToolStripMenuItem.Text = "&View Genome...";
			this.viewGenomeToolStripMenuItem.Click += new System.EventHandler(this.viewGenomeToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.hardwareInfoToolStripMenuItem,
            this.runDiagnosticsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// manualToolStripMenuItem
			// 
			this.manualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualToolStripMenuItem.Image")));
			this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
			this.manualToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.manualToolStripMenuItem.Text = "&Guide...";
			this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
			// 
			// hardwareInfoToolStripMenuItem
			// 
			this.hardwareInfoToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.infoIcon;
			this.hardwareInfoToolStripMenuItem.Name = "hardwareInfoToolStripMenuItem";
			this.hardwareInfoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.hardwareInfoToolStripMenuItem.Text = "&Hardware Info...";
			this.hardwareInfoToolStripMenuItem.Click += new System.EventHandler(this.hardwareInfoToolStripMenuItem_Click);
			// 
			// runDiagnosticsToolStripMenuItem
			// 
			this.runDiagnosticsToolStripMenuItem.Name = "runDiagnosticsToolStripMenuItem";
			this.runDiagnosticsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.runDiagnosticsToolStripMenuItem.Text = "&Run Diagnostics...";
			this.runDiagnosticsToolStripMenuItem.Click += new System.EventHandler(this.runDiagnosticsToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.ico16;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// paletteMenu
			// 
			this.paletteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.load1DToolStripMenuItem,
            this.loadDefaultToolStripMenuItem});
			this.paletteMenu.Name = "paletteContextMenu";
			this.paletteMenu.Size = new System.Drawing.Size(146, 70);
			// 
			// loadImageToolStripMenuItem
			// 
			this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
			this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.loadImageToolStripMenuItem.Text = "Load Image...";
			this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
			// 
			// load1DToolStripMenuItem
			// 
			this.load1DToolStripMenuItem.Name = "load1DToolStripMenuItem";
			this.load1DToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.load1DToolStripMenuItem.Text = "Load 1D...";
			this.load1DToolStripMenuItem.Click += new System.EventHandler(this.load1DToolStripMenuItem_Click);
			// 
			// loadDefaultToolStripMenuItem
			// 
			this.loadDefaultToolStripMenuItem.Name = "loadDefaultToolStripMenuItem";
			this.loadDefaultToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.loadDefaultToolStripMenuItem.Text = "Load Default";
			this.loadDefaultToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultToolStripMenuItem_Click);
			// 
			// renderContainer
			// 
			this.renderContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.renderContainer.Controls.Add(this.engineStatusPanel);
			this.renderContainer.Controls.Add(this.renderer);
			this.renderContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpProvider.SetHelpString(this.renderContainer, "");
			this.renderContainer.Location = new System.Drawing.Point(182, 25);
			this.renderContainer.Name = "renderContainer";
			this.helpProvider.SetShowHelp(this.renderContainer, false);
			this.renderContainer.Size = new System.Drawing.Size(619, 515);
			this.renderContainer.TabIndex = 6;
			this.renderContainer.Resize += new System.EventHandler(this.renderContainer_Resize);
			// 
			// engineStatusPanel
			// 
			this.engineStatusPanel.BackColor = System.Drawing.SystemColors.Control;
			this.engineStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.engineStatusPanel.Controls.Add(this.restartEngineButton);
			this.engineStatusPanel.Controls.Add(this.viewEngineErrorButton);
			this.engineStatusPanel.Controls.Add(this.engineStatusLabel);
			this.engineStatusPanel.Location = new System.Drawing.Point(182, 241);
			this.engineStatusPanel.Name = "engineStatusPanel";
			this.engineStatusPanel.Size = new System.Drawing.Size(256, 65);
			this.engineStatusPanel.TabIndex = 1;
			// 
			// restartEngineButton
			// 
			this.restartEngineButton.Location = new System.Drawing.Point(154, 33);
			this.restartEngineButton.Name = "restartEngineButton";
			this.restartEngineButton.Size = new System.Drawing.Size(95, 23);
			this.restartEngineButton.TabIndex = 1;
			this.restartEngineButton.Text = "Attempt Restart";
			this.restartEngineButton.UseVisualStyleBackColor = true;
			this.restartEngineButton.Visible = false;
			this.restartEngineButton.Click += new System.EventHandler(this.restartEngineButton_Click);
			// 
			// viewEngineErrorButton
			// 
			this.viewEngineErrorButton.Location = new System.Drawing.Point(6, 33);
			this.viewEngineErrorButton.Name = "viewEngineErrorButton";
			this.viewEngineErrorButton.Size = new System.Drawing.Size(95, 23);
			this.viewEngineErrorButton.TabIndex = 1;
			this.viewEngineErrorButton.Text = "View Error";
			this.viewEngineErrorButton.UseVisualStyleBackColor = true;
			this.viewEngineErrorButton.Visible = false;
			this.viewEngineErrorButton.Click += new System.EventHandler(this.viewEngineErrorButton_Click);
			// 
			// engineStatusLabel
			// 
			this.engineStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.engineStatusLabel.Location = new System.Drawing.Point(3, 3);
			this.engineStatusLabel.Margin = new System.Windows.Forms.Padding(3);
			this.engineStatusLabel.Name = "engineStatusLabel";
			this.engineStatusLabel.Size = new System.Drawing.Size(246, 24);
			this.engineStatusLabel.TabIndex = 0;
			this.engineStatusLabel.Text = "Engine Status";
			this.engineStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// renderer
			// 
			this.renderer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.renderer.BackColor = System.Drawing.Color.Black;
			this.renderer.Location = new System.Drawing.Point(126, 25);
			this.renderer.MainForm = null;
			this.renderer.Name = "renderer";
			this.renderer.Size = new System.Drawing.Size(354, 103);
			this.renderer.TabIndex = 0;
			this.renderer.Visible = false;
			this.renderer.VSync = false;
			this.renderer.MouseLeave += new System.EventHandler(this.handleHelpCtlMouseLeave);
			this.renderer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.handleRendererMouseMove);
			// 
			// savePanel
			// 
			this.savePanel.BackColor = System.Drawing.Color.Transparent;
			this.savePanel.Controls.Add(this.saveButton);
			this.savePanel.Controls.Add(this.nameLabel);
			this.savePanel.Controls.Add(this.nameTextBox);
			this.savePanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.savePanel.Location = new System.Drawing.Point(182, 0);
			this.savePanel.MinimumSize = new System.Drawing.Size(0, 25);
			this.savePanel.Name = "savePanel";
			this.savePanel.Size = new System.Drawing.Size(248, 25);
			this.savePanel.TabIndex = 5;
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpProvider.SetHelpString(this.saveButton, "Saves the fractal to the current library.");
			this.saveButton.Image = global::Fractron9000.Properties.Resources.saveIcon;
			this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveButton.Location = new System.Drawing.Point(191, 1);
			this.saveButton.Name = "saveButton";
			this.helpProvider.SetShowHelp(this.saveButton, true);
			this.saveButton.Size = new System.Drawing.Size(54, 22);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "Save";
			this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.Location = new System.Drawing.Point(0, 3);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(42, 20);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "Name:";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.helpProvider.SetHelpString(this.nameTextBox, "Edits the name of the currently viewed fractal.");
			this.nameTextBox.Location = new System.Drawing.Point(42, 3);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.nameTextBox.Name = "nameTextBox";
			this.helpProvider.SetShowHelp(this.nameTextBox, true);
			this.nameTextBox.Size = new System.Drawing.Size(146, 20);
			this.nameTextBox.TabIndex = 3;
			// 
			// localizedCheckbox
			// 
			this.localizedCheckbox.AutoSize = true;
			this.helpProvider.SetHelpString(this.localizedCheckbox, "Turn localized variations on/off. Localized variations operate within branch co-o" +
					"rdinates rather than world co-ordinates.");
			this.localizedCheckbox.Location = new System.Drawing.Point(9, 19);
			this.localizedCheckbox.Name = "localizedCheckbox";
			this.helpProvider.SetShowHelp(this.localizedCheckbox, true);
			this.localizedCheckbox.Size = new System.Drawing.Size(71, 17);
			this.localizedCheckbox.TabIndex = 0;
			this.localizedCheckbox.Text = "Localized";
			this.localizedCheckbox.UseVisualStyleBackColor = true;
			// 
			// backgroundColorPanel
			// 
			this.backgroundColorPanel.BackColor = System.Drawing.Color.Black;
			this.backgroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.helpProvider.SetHelpString(this.backgroundColorPanel, "Background Color Selector: Click to change the background color.");
			this.backgroundColorPanel.Location = new System.Drawing.Point(111, 97);
			this.backgroundColorPanel.Name = "backgroundColorPanel";
			this.helpProvider.SetShowHelp(this.backgroundColorPanel, true);
			this.backgroundColorPanel.Size = new System.Drawing.Size(52, 20);
			this.backgroundColorPanel.TabIndex = 9;
			this.backgroundColorPanel.Click += new System.EventHandler(this.backgroundColorPanel_Click);
			// 
			// libraryNameLabel
			// 
			this.helpProvider.SetHelpString(this.libraryNameLabel, "Displays the current library file name.");
			this.libraryNameLabel.Location = new System.Drawing.Point(3, 3);
			this.libraryNameLabel.Name = "libraryNameLabel";
			this.helpProvider.SetShowHelp(this.libraryNameLabel, true);
			this.libraryNameLabel.Size = new System.Drawing.Size(172, 26);
			this.libraryNameLabel.TabIndex = 3;
			this.libraryNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// libraryView
			// 
			this.libraryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.libraryView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader});
			this.libraryView.ContextMenuStrip = this.libraryItemMenu;
			this.libraryView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.helpProvider.SetHelpString(this.libraryView, "Lists the fractals in the current library. Double click a fractal to view. Right " +
					"click on a fractal for options.");
			this.libraryView.HideSelection = false;
			this.libraryView.LabelEdit = true;
			this.libraryView.LabelWrap = false;
			this.libraryView.Location = new System.Drawing.Point(0, 32);
			this.libraryView.MultiSelect = false;
			this.libraryView.Name = "libraryView";
			this.libraryView.ShowGroups = false;
			this.helpProvider.SetShowHelp(this.libraryView, true);
			this.libraryView.Size = new System.Drawing.Size(174, 457);
			this.libraryView.TabIndex = 2;
			this.libraryView.UseCompatibleStateImageBehavior = false;
			this.libraryView.View = System.Windows.Forms.View.Details;
			this.libraryView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.libraryView_AfterLabelEdit);
			this.libraryView.DoubleClick += new System.EventHandler(this.displayToolStripMenuItem_Click);
			// 
			// nameColumnHeader
			// 
			this.nameColumnHeader.Text = "Name";
			this.nameColumnHeader.Width = 146;
			// 
			// libraryItemMenu
			// 
			this.libraryItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem5,
            this.moveToTopToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem,
            this.moveToBottomToolStripMenuItem});
			this.libraryItemMenu.Name = "libraryItemMenu";
			this.libraryItemMenu.Size = new System.Drawing.Size(162, 164);
			this.libraryItemMenu.Opening += new System.ComponentModel.CancelEventHandler(this.libraryItemMenu_Opening);
			// 
			// viewToolStripMenuItem1
			// 
			this.viewToolStripMenuItem1.Image = global::Fractron9000.Properties.Resources.viewIcon;
			this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
			this.viewToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
			this.viewToolStripMenuItem1.Text = "&View";
			this.viewToolStripMenuItem1.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.renameToolStripMenuItem.Text = "&Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.deleteIcon;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(158, 6);
			// 
			// moveToTopToolStripMenuItem
			// 
			this.moveToTopToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.moveToTopIcon;
			this.moveToTopToolStripMenuItem.Name = "moveToTopToolStripMenuItem";
			this.moveToTopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.moveToTopToolStripMenuItem.Text = "Move to Top";
			this.moveToTopToolStripMenuItem.Click += new System.EventHandler(this.moveToTopToolStripMenuItem_Click);
			// 
			// moveUpToolStripMenuItem
			// 
			this.moveUpToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.moveUpIcon;
			this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
			this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.moveUpToolStripMenuItem.Text = "Move Up";
			this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
			// 
			// moveDownToolStripMenuItem
			// 
			this.moveDownToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.moveDownIcon;
			this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
			this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.moveDownToolStripMenuItem.Text = "Move Down";
			this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
			// 
			// moveToBottomToolStripMenuItem
			// 
			this.moveToBottomToolStripMenuItem.Image = global::Fractron9000.Properties.Resources.moveToBottomIcon;
			this.moveToBottomToolStripMenuItem.Name = "moveToBottomToolStripMenuItem";
			this.moveToBottomToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.moveToBottomToolStripMenuItem.Text = "Move to Bottom";
			this.moveToBottomToolStripMenuItem.Click += new System.EventHandler(this.moveToBottomToolStripMenuItem_Click);
			// 
			// brightnessSpinner
			// 
			this.brightnessSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.brightnessSpinner.FormatString = "0.##";
			this.helpProvider.SetHelpString(this.brightnessSpinner, "Adjusts the rendering brightness.");
			this.brightnessSpinner.Location = new System.Drawing.Point(110, 19);
			this.brightnessSpinner.MaxVal = 200;
			this.brightnessSpinner.MinorTicksPerMajorTick = 10;
			this.brightnessSpinner.Name = "brightnessSpinner";
			this.brightnessSpinner.PixelsPerMinorTick = 25;
			this.helpProvider.SetShowHelp(this.brightnessSpinner, true);
			this.brightnessSpinner.Size = new System.Drawing.Size(52, 20);
			this.brightnessSpinner.TabIndex = 5;
			this.brightnessSpinner.TabStop = false;
			// 
			// gammaSpinner
			// 
			this.gammaSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gammaSpinner.FormatString = "0.##";
			this.helpProvider.SetHelpString(this.gammaSpinner, "Adjusts the gamma level. High gamma tends to lighten only the dimmest parts of th" +
					"e image.");
			this.gammaSpinner.Location = new System.Drawing.Point(110, 45);
			this.gammaSpinner.MaxVal = 100;
			this.gammaSpinner.MinorTicksPerMajorTick = 10;
			this.gammaSpinner.MinVal = 0.1;
			this.gammaSpinner.Name = "gammaSpinner";
			this.gammaSpinner.PixelsPerMinorTick = 25;
			this.helpProvider.SetShowHelp(this.gammaSpinner, true);
			this.gammaSpinner.Size = new System.Drawing.Size(52, 20);
			this.gammaSpinner.TabIndex = 6;
			this.gammaSpinner.Value = 2;
			// 
			// vibrancySpinner
			// 
			this.vibrancySpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.vibrancySpinner.FormatString = "0.##";
			this.helpProvider.SetHelpString(this.vibrancySpinner, "Adjusts the color vibrancy. Higher vibrancy tends to produce more saturated color" +
					"s.");
			this.vibrancySpinner.Location = new System.Drawing.Point(110, 71);
			this.vibrancySpinner.MaxVal = 1;
			this.vibrancySpinner.MinorTicksPerMajorTick = 10;
			this.vibrancySpinner.Name = "vibrancySpinner";
			this.vibrancySpinner.PixelsPerMinorTick = 25;
			this.helpProvider.SetShowHelp(this.vibrancySpinner, true);
			this.vibrancySpinner.Size = new System.Drawing.Size(52, 20);
			this.vibrancySpinner.TabIndex = 6;
			this.vibrancySpinner.Value = 0.5;
			// 
			// weightSpinner
			// 
			this.weightSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpProvider.SetHelpString(this.weightSpinner, "Adjusts this branch\'s overall effect on the fractal\'s output.");
			this.weightSpinner.Location = new System.Drawing.Point(111, 18);
			this.weightSpinner.Margin = new System.Windows.Forms.Padding(2);
			this.weightSpinner.MaxVal = 16;
			this.weightSpinner.MinorTicksPerMajorTick = 12;
			this.weightSpinner.Name = "weightSpinner";
			this.weightSpinner.PixelsPerMinorTick = 24;
			this.helpProvider.SetShowHelp(this.weightSpinner, true);
			this.weightSpinner.Size = new System.Drawing.Size(52, 20);
			this.weightSpinner.TabIndex = 3;
			// 
			// colorWeightSpinner
			// 
			this.colorWeightSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpProvider.SetHelpString(this.colorWeightSpinner, "Adjusts how much effect this branch has on the fractal\'s color.");
			this.colorWeightSpinner.Location = new System.Drawing.Point(111, 42);
			this.colorWeightSpinner.Margin = new System.Windows.Forms.Padding(2);
			this.colorWeightSpinner.MinorTicksPerMajorTick = 12;
			this.colorWeightSpinner.Name = "colorWeightSpinner";
			this.colorWeightSpinner.PixelsPerMinorTick = 24;
			this.helpProvider.SetShowHelp(this.colorWeightSpinner, true);
			this.colorWeightSpinner.Size = new System.Drawing.Size(52, 20);
			this.colorWeightSpinner.TabIndex = 4;
			this.colorWeightSpinner.Value = 0.5;
			// 
			// chromaControl
			// 
			this.chromaControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chromaControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.chromaControl.ContextMenuStrip = this.paletteMenu;
			this.helpProvider.SetHelpString(this.chromaControl, "Color Select: Left click to select branch color. Right click to change the palett" +
					"e.");
			this.chromaControl.Location = new System.Drawing.Point(18, 69);
			this.chromaControl.Name = "chromaControl";
			this.helpProvider.SetShowHelp(this.chromaControl, true);
			this.chromaControl.Size = new System.Drawing.Size(130, 130);
			this.chromaControl.TabIndex = 0;
			// 
			// sideBar
			// 
			this.sideBar.Controls.Add(this.parametersPage);
			this.sideBar.Controls.Add(this.libraryPage);
			this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sideBar.Location = new System.Drawing.Point(0, 25);
			this.sideBar.Name = "sideBar";
			this.sideBar.SelectedIndex = 0;
			this.sideBar.Size = new System.Drawing.Size(182, 515);
			this.sideBar.TabIndex = 7;
			// 
			// parametersPage
			// 
			this.parametersPage.Controls.Add(this.variGroupBox);
			this.parametersPage.Controls.Add(this.toneGroupBox);
			this.parametersPage.Controls.Add(this.colorGroupBox);
			this.parametersPage.Location = new System.Drawing.Point(4, 22);
			this.parametersPage.Name = "parametersPage";
			this.parametersPage.Padding = new System.Windows.Forms.Padding(3);
			this.parametersPage.Size = new System.Drawing.Size(174, 489);
			this.parametersPage.TabIndex = 0;
			this.parametersPage.Text = "Parameters";
			this.parametersPage.UseVisualStyleBackColor = true;
			// 
			// variGroupBox
			// 
			this.variGroupBox.Controls.Add(this.localizedCheckbox);
			this.variGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.variGroupBox.Location = new System.Drawing.Point(3, 187);
			this.variGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.variGroupBox.Name = "variGroupBox";
			this.variGroupBox.Size = new System.Drawing.Size(168, 97);
			this.variGroupBox.TabIndex = 9;
			this.variGroupBox.TabStop = false;
			this.variGroupBox.Text = "Variations";
			// 
			// toneGroupBox
			// 
			this.toneGroupBox.Controls.Add(this.backgroundColorPanel);
			this.toneGroupBox.Controls.Add(this.brightnessSpinner);
			this.toneGroupBox.Controls.Add(this.label4);
			this.toneGroupBox.Controls.Add(this.label2);
			this.toneGroupBox.Controls.Add(this.label3);
			this.toneGroupBox.Controls.Add(this.label1);
			this.toneGroupBox.Controls.Add(this.gammaSpinner);
			this.toneGroupBox.Controls.Add(this.vibrancySpinner);
			this.toneGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.toneGroupBox.Location = new System.Drawing.Point(3, 3);
			this.toneGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.toneGroupBox.Name = "toneGroupBox";
			this.toneGroupBox.Size = new System.Drawing.Size(168, 123);
			this.toneGroupBox.TabIndex = 9;
			this.toneGroupBox.TabStop = false;
			this.toneGroupBox.Text = "Tone Mapping";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(6, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Background Color";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(6, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Vibrancy";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(6, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Gamma";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Brightness";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.Controls.Add(this.chromaControl);
			this.colorGroupBox.Controls.Add(this.weightSpinner);
			this.colorGroupBox.Controls.Add(this.colorWeightLabel);
			this.colorGroupBox.Controls.Add(this.weightLabel);
			this.colorGroupBox.Controls.Add(this.colorWeightSpinner);
			this.colorGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.colorGroupBox.Location = new System.Drawing.Point(3, 284);
			this.colorGroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(168, 202);
			this.colorGroupBox.TabIndex = 9;
			this.colorGroupBox.TabStop = false;
			this.colorGroupBox.Text = "Color";
			// 
			// colorWeightLabel
			// 
			this.colorWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.colorWeightLabel.Location = new System.Drawing.Point(6, 42);
			this.colorWeightLabel.Name = "colorWeightLabel";
			this.colorWeightLabel.Size = new System.Drawing.Size(100, 20);
			this.colorWeightLabel.TabIndex = 8;
			this.colorWeightLabel.Text = "Color Weight";
			this.colorWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// weightLabel
			// 
			this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.weightLabel.Location = new System.Drawing.Point(6, 16);
			this.weightLabel.Name = "weightLabel";
			this.weightLabel.Size = new System.Drawing.Size(100, 20);
			this.weightLabel.TabIndex = 8;
			this.weightLabel.Text = "Weight";
			this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// libraryPage
			// 
			this.libraryPage.Controls.Add(this.libraryNameLabel);
			this.libraryPage.Controls.Add(this.libraryView);
			this.libraryPage.Location = new System.Drawing.Point(4, 22);
			this.libraryPage.Name = "libraryPage";
			this.libraryPage.Padding = new System.Windows.Forms.Padding(3);
			this.libraryPage.Size = new System.Drawing.Size(174, 489);
			this.libraryPage.TabIndex = 1;
			this.libraryPage.Text = "Library";
			this.libraryPage.UseVisualStyleBackColor = true;
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.BackColor = System.Drawing.Color.Transparent;
			this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.zoomInToolStripButton,
            this.zoomOutToolStripButton,
            this.flipVerticalToolStripButton,
            this.viewPreviousToolStripButton,
            this.viewNextToolStripButton,
            this.toggleEditorToolStripButton,
            this.toolStripSeparator2,
            this.addBranchToolStripButton,
            this.removeBranchToolStripButton,
            this.duplicateBranchToolStripButton,
            this.invertBranchToolStripButton});
			this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.mainToolStrip.Location = new System.Drawing.Point(440, 0);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
			this.mainToolStrip.Size = new System.Drawing.Size(261, 25);
			this.mainToolStrip.TabIndex = 2;
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = global::Fractron9000.Properties.Resources.newIcon;
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "New";
			this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// zoomInToolStripButton
			// 
			this.zoomInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomInToolStripButton.Image = global::Fractron9000.Properties.Resources.zoomInIcon;
			this.zoomInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomInToolStripButton.Name = "zoomInToolStripButton";
			this.zoomInToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.zoomInToolStripButton.Text = "Zoom In";
			this.zoomInToolStripButton.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
			// 
			// zoomOutToolStripButton
			// 
			this.zoomOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.zoomOutToolStripButton.Image = global::Fractron9000.Properties.Resources.zoomOutIcon;
			this.zoomOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.zoomOutToolStripButton.Name = "zoomOutToolStripButton";
			this.zoomOutToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.zoomOutToolStripButton.Text = "Zoom Out";
			this.zoomOutToolStripButton.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
			// 
			// flipVerticalToolStripButton
			// 
			this.flipVerticalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.flipVerticalToolStripButton.Image = global::Fractron9000.Properties.Resources.flipVerticalIcon;
			this.flipVerticalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.flipVerticalToolStripButton.Name = "flipVerticalToolStripButton";
			this.flipVerticalToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.flipVerticalToolStripButton.Text = "Flip Vertical";
			this.flipVerticalToolStripButton.Click += new System.EventHandler(this.flipVerticalToolStripMenuItem_Click);
			// 
			// viewPreviousToolStripButton
			// 
			this.viewPreviousToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.viewPreviousToolStripButton.Image = global::Fractron9000.Properties.Resources.viewPrevIcon;
			this.viewPreviousToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewPreviousToolStripButton.Name = "viewPreviousToolStripButton";
			this.viewPreviousToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.viewPreviousToolStripButton.Text = "View Previous";
			this.viewPreviousToolStripButton.Click += new System.EventHandler(this.prevToolStripMenuItem_Click);
			// 
			// viewNextToolStripButton
			// 
			this.viewNextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.viewNextToolStripButton.Image = global::Fractron9000.Properties.Resources.viewNextIcon;
			this.viewNextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewNextToolStripButton.Name = "viewNextToolStripButton";
			this.viewNextToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.viewNextToolStripButton.Text = "View Next";
			this.viewNextToolStripButton.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
			// 
			// toggleEditorToolStripButton
			// 
			this.toggleEditorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toggleEditorToolStripButton.Image = global::Fractron9000.Properties.Resources.viewEditorIcon;
			this.toggleEditorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toggleEditorToolStripButton.Name = "toggleEditorToolStripButton";
			this.toggleEditorToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.toggleEditorToolStripButton.Text = "Toggle Editor";
			this.toggleEditorToolStripButton.Click += new System.EventHandler(this.toggleEditorsToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// addBranchToolStripButton
			// 
			this.addBranchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.addBranchToolStripButton.Image = global::Fractron9000.Properties.Resources.addBranchIcon;
			this.addBranchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addBranchToolStripButton.Name = "addBranchToolStripButton";
			this.addBranchToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.addBranchToolStripButton.Text = "Add Branch";
			this.addBranchToolStripButton.Click += new System.EventHandler(this.addBranchToolStripMenuItem_Click);
			// 
			// removeBranchToolStripButton
			// 
			this.removeBranchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.removeBranchToolStripButton.Image = global::Fractron9000.Properties.Resources.removeBranchIcon;
			this.removeBranchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.removeBranchToolStripButton.Name = "removeBranchToolStripButton";
			this.removeBranchToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.removeBranchToolStripButton.Text = "Remove Branch";
			this.removeBranchToolStripButton.Click += new System.EventHandler(this.removeBranchToolStripMenuItem_Click);
			// 
			// duplicateBranchToolStripButton
			// 
			this.duplicateBranchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.duplicateBranchToolStripButton.Image = global::Fractron9000.Properties.Resources.duplicateBranchIcon;
			this.duplicateBranchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.duplicateBranchToolStripButton.Name = "duplicateBranchToolStripButton";
			this.duplicateBranchToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.duplicateBranchToolStripButton.Text = "Duplicate Branch";
			this.duplicateBranchToolStripButton.Click += new System.EventHandler(this.duplicateBranchToolStripMenuItem_Click);
			// 
			// invertBranchToolStripButton
			// 
			this.invertBranchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.invertBranchToolStripButton.Image = global::Fractron9000.Properties.Resources.invertBranchIcon;
			this.invertBranchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.invertBranchToolStripButton.Name = "invertBranchToolStripButton";
			this.invertBranchToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.invertBranchToolStripButton.Text = "Invert Branch";
			this.invertBranchToolStripButton.Click += new System.EventHandler(this.invertBranchToolStripMenuItem_Click);
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.SystemColors.Control;
			this.topPanel.BackgroundImage = global::Fractron9000.Properties.Resources.topbar_bg;
			this.topPanel.Controls.Add(this.mainToolStrip);
			this.topPanel.Controls.Add(this.panel1);
			this.topPanel.Controls.Add(this.savePanel);
			this.topPanel.Controls.Add(this.divPanel2);
			this.topPanel.Controls.Add(this.mainMenuStrip);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.MinimumSize = new System.Drawing.Size(0, 25);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(801, 25);
			this.topPanel.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = global::Fractron9000.Properties.Resources.divider;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(430, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 25);
			this.panel1.TabIndex = 6;
			// 
			// divPanel2
			// 
			this.divPanel2.BackColor = System.Drawing.Color.Transparent;
			this.divPanel2.BackgroundImage = global::Fractron9000.Properties.Resources.divider;
			this.divPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.divPanel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.divPanel2.Location = new System.Drawing.Point(172, 0);
			this.divPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.divPanel2.Name = "divPanel2";
			this.divPanel2.Size = new System.Drawing.Size(10, 25);
			this.divPanel2.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(801, 562);
			this.Controls.Add(this.renderContainer);
			this.Controls.Add(this.sideBar);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.topPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.Text = "Fractron 9000 Beta";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.paletteMenu.ResumeLayout(false);
			this.renderContainer.ResumeLayout(false);
			this.engineStatusPanel.ResumeLayout(false);
			this.savePanel.ResumeLayout(false);
			this.savePanel.PerformLayout();
			this.libraryItemMenu.ResumeLayout(false);
			this.sideBar.ResumeLayout(false);
			this.parametersPage.ResumeLayout(false);
			this.variGroupBox.ResumeLayout(false);
			this.variGroupBox.PerformLayout();
			this.toneGroupBox.ResumeLayout(false);
			this.colorGroupBox.ResumeLayout(false);
			this.libraryPage.ResumeLayout(false);
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addBranchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeBranchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hardwareInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
		private MTUtil.UI.DragSpin gammaSpinner;
		private MTUtil.UI.DragSpin brightnessSpinner;
		private MTUtil.UI.DragSpin colorWeightSpinner;
		private MTUtil.UI.DragSpin weightSpinner;
		private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
		private ChromaControl chromaControl;
		private System.Windows.Forms.Panel renderContainer;
		private RenderControl renderer;
		private System.Windows.Forms.HelpProvider helpProvider;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem invertBranchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem duplicateBranchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toggleEditorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFlameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prevToolStripMenuItem;
		private MTUtil.UI.DragSpin vibrancySpinner;
		private System.Windows.Forms.ToolStripMenuItem viewGenomeToolStripMenuItem;
		private System.Windows.Forms.TabControl sideBar;
		private System.Windows.Forms.TabPage parametersPage;
		private System.Windows.Forms.TabPage libraryPage;
		private System.Windows.Forms.ListView libraryView;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox variGroupBox;
		private System.Windows.Forms.GroupBox toneGroupBox;
		private System.Windows.Forms.GroupBox colorGroupBox;
		private System.Windows.Forms.Label colorWeightLabel;
		private System.Windows.Forms.Label weightLabel;
		private System.Windows.Forms.ToolStripMenuItem saveLibraryToolStripMenuItem;
		private System.Windows.Forms.CheckBox localizedCheckbox;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ContextMenuStrip paletteMenu;
		private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadDefaultToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip libraryItemMenu;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.Label libraryNameLabel;
		private System.Windows.Forms.ToolStripMenuItem openFractronFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem moveToTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveToBottomToolStripMenuItem;
		private System.Windows.Forms.Panel backgroundColorPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripMenuItem load1DToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetViewToolStripMenuItem;
		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton zoomInToolStripButton;
		private System.Windows.Forms.ToolStripButton zoomOutToolStripButton;
		private System.Windows.Forms.ToolStripButton flipVerticalToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton viewPreviousToolStripButton;
		private System.Windows.Forms.ToolStripButton viewNextToolStripButton;
		private System.Windows.Forms.ToolStripButton addBranchToolStripButton;
		private System.Windows.Forms.ToolStripButton removeBranchToolStripButton;
		private System.Windows.Forms.ToolStripButton duplicateBranchToolStripButton;
		private System.Windows.Forms.ToolStripButton invertBranchToolStripButton;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Panel savePanel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel divPanel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripButton toggleEditorToolStripButton;
		private System.Windows.Forms.Panel engineStatusPanel;
		private System.Windows.Forms.Label engineStatusLabel;
		private System.Windows.Forms.Button viewEngineErrorButton;
		private System.Windows.Forms.Button restartEngineButton;
		private System.Windows.Forms.ToolStripMenuItem runDiagnosticsToolStripMenuItem;

	}
}