namespace OdooTool
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.btnSetSourceServer = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.HeaderPanel = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.checkDisableConstraints = new Telerik.WinControls.UI.RadCheckBox();
            this.loadDestinationTables = new Telerik.WinControls.UI.RadButton();
            this.btnSetDestinationServer = new Telerik.WinControls.UI.RadButton();
            this.loadSourceTables = new Telerik.WinControls.UI.RadButton();
            this.TablesPanel = new Telerik.WinControls.UI.SplitPanel();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel5 = new Telerik.WinControls.UI.SplitPanel();
            this.treeOrig = new OdooTool.Helpers.RadReadOnlyTreeView();
            this.splitPanel6 = new Telerik.WinControls.UI.SplitPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new Telerik.WinControls.UI.RadButton();
            this.btnCopy = new Telerik.WinControls.UI.RadButton();
            this.btnExecute = new Telerik.WinControls.UI.RadButton();
            this.splitPanel7 = new Telerik.WinControls.UI.SplitPanel();
            this.treeDest = new Telerik.WinControls.UI.RadTreeView();
            this.LabelQueryPanel = new Telerik.WinControls.UI.SplitPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ResultPanel = new Telerik.WinControls.UI.SplitPanel();
            this.txtResult = new Telerik.WinControls.UI.RadTextBox();
            this.ProgressPanel = new Telerik.WinControls.UI.SplitPanel();
            this.progressBarResult = new Telerik.WinControls.UI.RadProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSourceServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisableConstraints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDestinationTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSourceTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablesPanel)).BeginInit();
            this.TablesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel5)).BeginInit();
            this.splitPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel6)).BeginInit();
            this.splitPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel7)).BeginInit();
            this.splitPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelQueryPanel)).BeginInit();
            this.LabelQueryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPanel)).BeginInit();
            this.ResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPanel)).BeginInit();
            this.ProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetSourceServer
            // 
            this.btnSetSourceServer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnSetSourceServer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetSourceServer.Image = global::OdooTool.Properties.Resources.tool_icon;
            this.btnSetSourceServer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetSourceServer.Location = new System.Drawing.Point(0, 0);
            this.btnSetSourceServer.Name = "btnSetSourceServer";
            this.btnSetSourceServer.Size = new System.Drawing.Size(43, 40);
            this.btnSetSourceServer.TabIndex = 2;
            this.btnSetSourceServer.ThemeName = "VisualStudio2012Light";
            this.btnSetSourceServer.Click += new System.EventHandler(this.btnSetSourceServer_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.HeaderPanel);
            this.radSplitContainer1.Controls.Add(this.TablesPanel);
            this.radSplitContainer1.Controls.Add(this.LabelQueryPanel);
            this.radSplitContainer1.Controls.Add(this.ResultPanel);
            this.radSplitContainer1.Controls.Add(this.ProgressPanel);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(1007, 633);
            this.radSplitContainer1.SplitterWidth = 3;
            this.radSplitContainer1.TabIndex = 5;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "VisualStudio2012Light";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.radGroupBox1);
            this.HeaderPanel.Controls.Add(this.loadDestinationTables);
            this.HeaderPanel.Controls.Add(this.btnSetDestinationServer);
            this.HeaderPanel.Controls.Add(this.loadSourceTables);
            this.HeaderPanel.Controls.Add(this.btnSetSourceServer);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            // 
            // 
            // 
            this.HeaderPanel.RootElement.MaxSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.RootElement.MinSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.Size = new System.Drawing.Size(1007, 40);
            this.HeaderPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1371981F);
            this.HeaderPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -76);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.TabStop = false;
            this.HeaderPanel.Text = "splitPanel1";
            this.HeaderPanel.ThemeName = "VisualStudio2012Light";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.checkDisableConstraints);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Options";
            this.radGroupBox1.Location = new System.Drawing.Point(184, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(12, 18, 12, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(623, 40);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "Options";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // checkDisableConstraints
            // 
            this.checkDisableConstraints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDisableConstraints.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkDisableConstraints.Location = new System.Drawing.Point(12, 18);
            this.checkDisableConstraints.Name = "checkDisableConstraints";
            this.checkDisableConstraints.Size = new System.Drawing.Size(117, 20);
            this.checkDisableConstraints.TabIndex = 7;
            this.checkDisableConstraints.Text = "Disable constraints";
            this.checkDisableConstraints.ThemeName = "VisualStudio2012Light";
            this.checkDisableConstraints.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // loadDestinationTables
            // 
            this.loadDestinationTables.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.loadDestinationTables.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadDestinationTables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadDestinationTables.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadDestinationTables.Location = new System.Drawing.Point(807, 0);
            this.loadDestinationTables.Name = "loadDestinationTables";
            this.loadDestinationTables.Size = new System.Drawing.Size(157, 40);
            this.loadDestinationTables.TabIndex = 4;
            this.loadDestinationTables.Text = "Load tables (Destination)";
            this.loadDestinationTables.ThemeName = "VisualStudio2012Light";
            this.loadDestinationTables.Click += new System.EventHandler(this.loadDestinationTables_Click);
            // 
            // btnSetDestinationServer
            // 
            this.btnSetDestinationServer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnSetDestinationServer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetDestinationServer.Image = global::OdooTool.Properties.Resources.tool_icon;
            this.btnSetDestinationServer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetDestinationServer.Location = new System.Drawing.Point(964, 0);
            this.btnSetDestinationServer.Name = "btnSetDestinationServer";
            this.btnSetDestinationServer.Size = new System.Drawing.Size(43, 40);
            this.btnSetDestinationServer.TabIndex = 5;
            this.btnSetDestinationServer.ThemeName = "VisualStudio2012Light";
            this.btnSetDestinationServer.Click += new System.EventHandler(this.btnSetDestinationServer_Click);
            // 
            // loadSourceTables
            // 
            this.loadSourceTables.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.loadSourceTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadSourceTables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadSourceTables.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadSourceTables.Location = new System.Drawing.Point(43, 0);
            this.loadSourceTables.Name = "loadSourceTables";
            this.loadSourceTables.Size = new System.Drawing.Size(141, 40);
            this.loadSourceTables.TabIndex = 3;
            this.loadSourceTables.Text = "Load tables (Source)";
            this.loadSourceTables.ThemeName = "VisualStudio2012Light";
            this.loadSourceTables.Click += new System.EventHandler(this.loadSourceTables_Click);
            // 
            // TablesPanel
            // 
            this.TablesPanel.Controls.Add(this.radSplitContainer2);
            this.TablesPanel.Location = new System.Drawing.Point(0, 43);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.TablesPanel.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.TablesPanel.Size = new System.Drawing.Size(1007, 361);
            this.TablesPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.3829308F);
            this.TablesPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 187);
            this.TablesPanel.TabIndex = 1;
            this.TablesPanel.TabStop = false;
            this.TablesPanel.Text = "splitPanel2";
            this.TablesPanel.ThemeName = "VisualStudio2012Light";
            // 
            // radSplitContainer2
            // 
            this.radSplitContainer2.Controls.Add(this.splitPanel5);
            this.radSplitContainer2.Controls.Add(this.splitPanel6);
            this.radSplitContainer2.Controls.Add(this.splitPanel7);
            this.radSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer2.Location = new System.Drawing.Point(5, 5);
            this.radSplitContainer2.Name = "radSplitContainer2";
            // 
            // 
            // 
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer2.Size = new System.Drawing.Size(997, 351);
            this.radSplitContainer2.SplitterWidth = 3;
            this.radSplitContainer2.TabIndex = 0;
            this.radSplitContainer2.TabStop = false;
            this.radSplitContainer2.Text = "radSplitContainer2";
            this.radSplitContainer2.ThemeName = "VisualStudio2012Light";
            // 
            // splitPanel5
            // 
            this.splitPanel5.Controls.Add(this.treeOrig);
            this.splitPanel5.Location = new System.Drawing.Point(0, 0);
            this.splitPanel5.Name = "splitPanel5";
            // 
            // 
            // 
            this.splitPanel5.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel5.Size = new System.Drawing.Size(446, 351);
            this.splitPanel5.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1155378F, 0F);
            this.splitPanel5.SizeInfo.SplitterCorrection = new System.Drawing.Size(87, 0);
            this.splitPanel5.TabIndex = 0;
            this.splitPanel5.TabStop = false;
            this.splitPanel5.Text = "splitPanel5";
            this.splitPanel5.ThemeName = "VisualStudio2012Light";
            // 
            // treeOrig
            // 
            this.treeOrig.CheckBoxes = true;
            this.treeOrig.CheckBoxReadOnly = true;
            this.treeOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeOrig.Location = new System.Drawing.Point(0, 0);
            this.treeOrig.Name = "treeOrig";
            this.treeOrig.Size = new System.Drawing.Size(446, 351);
            this.treeOrig.TabIndex = 5;
            this.treeOrig.Text = "radTreeView1";
            this.treeOrig.ThemeName = "VisualStudio2012Light";
            this.treeOrig.TriStateMode = true;
            // 
            // splitPanel6
            // 
            this.splitPanel6.Controls.Add(this.pictureBox1);
            this.splitPanel6.Controls.Add(this.btnGenerate);
            this.splitPanel6.Controls.Add(this.btnCopy);
            this.splitPanel6.Controls.Add(this.btnExecute);
            this.splitPanel6.Location = new System.Drawing.Point(449, 0);
            this.splitPanel6.Name = "splitPanel6";
            // 
            // 
            // 
            this.splitPanel6.RootElement.MaxSize = new System.Drawing.Size(90, 0);
            this.splitPanel6.RootElement.MinSize = new System.Drawing.Size(90, 0);
            this.splitPanel6.Size = new System.Drawing.Size(90, 351);
            this.splitPanel6.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2416999F, 0F);
            this.splitPanel6.SizeInfo.MaximumSize = new System.Drawing.Size(90, 0);
            this.splitPanel6.SizeInfo.MinimumSize = new System.Drawing.Size(90, 0);
            this.splitPanel6.SizeInfo.SplitterCorrection = new System.Drawing.Size(-182, 0);
            this.splitPanel6.TabIndex = 1;
            this.splitPanel6.TabStop = false;
            this.splitPanel6.Text = "splitPanel6";
            this.splitPanel6.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.splitPanel6.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::OdooTool.Properties.Resources.ToRight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Location = new System.Drawing.Point(0, 216);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 45);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate SQL";
            this.btnGenerate.TextWrap = true;
            this.btnGenerate.ThemeName = "VisualStudio2012Light";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCopy.Enabled = false;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopy.Location = new System.Drawing.Point(0, 261);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(90, 45);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy SQL";
            this.btnCopy.TextWrap = true;
            this.btnCopy.ThemeName = "VisualStudio2012Light";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExecute.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExecute.Location = new System.Drawing.Point(0, 306);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(90, 45);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute Migration";
            this.btnExecute.TextWrap = true;
            this.btnExecute.ThemeName = "VisualStudio2012Light";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // splitPanel7
            // 
            this.splitPanel7.Controls.Add(this.treeDest);
            this.splitPanel7.Location = new System.Drawing.Point(542, 0);
            this.splitPanel7.Name = "splitPanel7";
            // 
            // 
            // 
            this.splitPanel7.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.splitPanel7.Size = new System.Drawing.Size(455, 351);
            this.splitPanel7.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.126162F, 0F);
            this.splitPanel7.SizeInfo.SplitterCorrection = new System.Drawing.Size(95, 0);
            this.splitPanel7.TabIndex = 2;
            this.splitPanel7.TabStop = false;
            this.splitPanel7.Text = "splitPanel7";
            this.splitPanel7.ThemeName = "VisualStudio2012Light";
            // 
            // treeDest
            // 
            this.treeDest.CheckBoxes = true;
            this.treeDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDest.Location = new System.Drawing.Point(0, 0);
            this.treeDest.Name = "treeDest";
            this.treeDest.Size = new System.Drawing.Size(455, 351);
            this.treeDest.TabIndex = 6;
            this.treeDest.Text = "radTreeView1";
            this.treeDest.ThemeName = "VisualStudio2012Light";
            this.treeDest.TriStateMode = true;
            this.treeDest.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.treeDest_NodeCheckedChanged);
            // 
            // LabelQueryPanel
            // 
            this.LabelQueryPanel.Controls.Add(this.radLabel1);
            this.LabelQueryPanel.Location = new System.Drawing.Point(0, 407);
            this.LabelQueryPanel.Name = "LabelQueryPanel";
            this.LabelQueryPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // 
            // 
            this.LabelQueryPanel.RootElement.MaxSize = new System.Drawing.Size(0, 30);
            this.LabelQueryPanel.RootElement.MinSize = new System.Drawing.Size(0, 30);
            this.LabelQueryPanel.Size = new System.Drawing.Size(1007, 30);
            this.LabelQueryPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1516908F);
            this.LabelQueryPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 30);
            this.LabelQueryPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 30);
            this.LabelQueryPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -56);
            this.LabelQueryPanel.TabIndex = 2;
            this.LabelQueryPanel.TabStop = false;
            this.LabelQueryPanel.Text = "splitPanel3";
            this.LabelQueryPanel.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radLabel1.Location = new System.Drawing.Point(0, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Query result";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.txtResult);
            this.ResultPanel.Location = new System.Drawing.Point(0, 440);
            this.ResultPanel.Name = "ResultPanel";
            // 
            // 
            // 
            this.ResultPanel.RootElement.MaxSize = new System.Drawing.Size(0, 150);
            this.ResultPanel.RootElement.MinSize = new System.Drawing.Size(0, 150);
            this.ResultPanel.Size = new System.Drawing.Size(1007, 150);
            this.ResultPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.03993559F);
            this.ResultPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 150);
            this.ResultPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 150);
            this.ResultPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 27);
            this.ResultPanel.TabIndex = 3;
            this.ResultPanel.TabStop = false;
            this.ResultPanel.Text = "splitPanel4";
            this.ResultPanel.ThemeName = "VisualStudio2012Light";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = false;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(1007, 150);
            this.txtResult.TabIndex = 0;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Controls.Add(this.progressBarResult);
            this.ProgressPanel.Location = new System.Drawing.Point(0, 593);
            this.ProgressPanel.Name = "ProgressPanel";
            // 
            // 
            // 
            this.ProgressPanel.RootElement.MaxSize = new System.Drawing.Size(0, 40);
            this.ProgressPanel.RootElement.MinSize = new System.Drawing.Size(0, 40);
            this.ProgressPanel.Size = new System.Drawing.Size(1007, 40);
            this.ProgressPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1339775F);
            this.ProgressPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 40);
            this.ProgressPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 40);
            this.ProgressPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -82);
            this.ProgressPanel.TabIndex = 4;
            this.ProgressPanel.TabStop = false;
            this.ProgressPanel.Text = "splitPanel8";
            this.ProgressPanel.ThemeName = "VisualStudio2012Light";
            // 
            // progressBarResult
            // 
            this.progressBarResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarResult.Location = new System.Drawing.Point(0, 0);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.SeparatorGradientAngle = 4;
            this.progressBarResult.SeparatorWidth = 5;
            this.progressBarResult.ShowProgressIndicators = true;
            this.progressBarResult.Size = new System.Drawing.Size(1007, 40);
            this.progressBarResult.Step = 1;
            this.progressBarResult.StepWidth = 30;
            this.progressBarResult.SweepAngle = 60;
            this.progressBarResult.TabIndex = 6;
            this.progressBarResult.TabStop = false;
            this.progressBarResult.Text = "0 %";
            this.progressBarResult.ThemeName = "VisualStudio2012Light";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 633);
            this.Controls.Add(this.radSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migration Tool PostgreSQL - Optimized for Odoo";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSourceServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDisableConstraints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDestinationTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSourceTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablesPanel)).EndInit();
            this.TablesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel5)).EndInit();
            this.splitPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel6)).EndInit();
            this.splitPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel7)).EndInit();
            this.splitPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelQueryPanel)).EndInit();
            this.LabelQueryPanel.ResumeLayout(false);
            this.LabelQueryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPanel)).EndInit();
            this.ResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPanel)).EndInit();
            this.ProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSetSourceServer;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel HeaderPanel;
        private Telerik.WinControls.UI.SplitPanel TablesPanel;
        private OdooTool.Helpers.RadReadOnlyTreeView treeOrig;
        private Telerik.WinControls.UI.SplitPanel LabelQueryPanel;
        private Telerik.WinControls.UI.RadButton loadDestinationTables;
        private Telerik.WinControls.UI.RadButton loadSourceTables;
        private Telerik.WinControls.UI.RadTextBox txtResult;
        private Telerik.WinControls.UI.SplitPanel ResultPanel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnSetDestinationServer;
        private Telerik.WinControls.UI.RadTreeView treeDest;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer2;
        private Telerik.WinControls.UI.SplitPanel splitPanel5;
        private Telerik.WinControls.UI.SplitPanel splitPanel6;
        private Telerik.WinControls.UI.SplitPanel splitPanel7;
        private Telerik.WinControls.UI.RadButton btnGenerate;
        private Telerik.WinControls.UI.RadButton btnExecute;
        private Telerik.WinControls.UI.RadButton btnCopy;
        private Telerik.WinControls.UI.SplitPanel ProgressPanel;
        private Telerik.WinControls.UI.RadProgressBar progressBarResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadCheckBox checkDisableConstraints;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;

    }
}