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
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.loadDestinationTables = new Telerik.WinControls.UI.RadButton();
            this.btnSetDestinationServer = new Telerik.WinControls.UI.RadButton();
            this.loadSourceTables = new Telerik.WinControls.UI.RadButton();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radSplitContainer2 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel5 = new Telerik.WinControls.UI.SplitPanel();
            this.treeOrig = new Telerik.WinControls.UI.RadTreeView();
            this.splitPanel6 = new Telerik.WinControls.UI.SplitPanel();
            this.btnGenerate = new Telerik.WinControls.UI.RadButton();
            this.btnCopy = new Telerik.WinControls.UI.RadButton();
            this.btnExecute = new Telerik.WinControls.UI.RadButton();
            this.splitPanel7 = new Telerik.WinControls.UI.SplitPanel();
            this.treeDest = new Telerik.WinControls.UI.RadTreeView();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel4 = new Telerik.WinControls.UI.SplitPanel();
            this.txtResult = new Telerik.WinControls.UI.RadTextBox();
            this.btnToggleFK = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSourceServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadDestinationTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSourceTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).BeginInit();
            this.radSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel5)).BeginInit();
            this.splitPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel6)).BeginInit();
            this.splitPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel7)).BeginInit();
            this.splitPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).BeginInit();
            this.splitPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleFK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
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
            this.btnSetSourceServer.Size = new System.Drawing.Size(43, 38);
            this.btnSetSourceServer.TabIndex = 2;
            this.btnSetSourceServer.ThemeName = "VisualStudio2012Light";
            this.btnSetSourceServer.Click += new System.EventHandler(this.btnSetSourceServer_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel3);
            this.radSplitContainer1.Controls.Add(this.splitPanel4);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1007, 633);
            this.radSplitContainer1.TabIndex = 5;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "VisualStudio2012Light";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.btnToggleFK);
            this.splitPanel1.Controls.Add(this.loadDestinationTables);
            this.splitPanel1.Controls.Add(this.btnSetDestinationServer);
            this.splitPanel1.Controls.Add(this.loadSourceTables);
            this.splitPanel1.Controls.Add(this.btnSetSourceServer);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1007, 38);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1891026F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -109);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "VisualStudio2012Light";
            // 
            // loadDestinationTables
            // 
            this.loadDestinationTables.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.loadDestinationTables.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadDestinationTables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadDestinationTables.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadDestinationTables.Location = new System.Drawing.Point(807, 0);
            this.loadDestinationTables.Name = "loadDestinationTables";
            this.loadDestinationTables.Size = new System.Drawing.Size(157, 38);
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
            this.btnSetDestinationServer.Size = new System.Drawing.Size(43, 38);
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
            this.loadSourceTables.Size = new System.Drawing.Size(141, 38);
            this.loadSourceTables.TabIndex = 3;
            this.loadSourceTables.Text = "Load tables (Source)";
            this.loadSourceTables.ThemeName = "VisualStudio2012Light";
            this.loadSourceTables.Click += new System.EventHandler(this.loadSourceTables_Click);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radSplitContainer2);
            this.splitPanel2.Location = new System.Drawing.Point(0, 41);
            this.splitPanel2.Name = "splitPanel2";
            this.splitPanel2.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1007, 372);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.3461539F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 163);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "VisualStudio2012Light";
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
            this.radSplitContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer2.Size = new System.Drawing.Size(997, 362);
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
            this.splitPanel5.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel5.Size = new System.Drawing.Size(445, 362);
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
            this.treeOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeOrig.Location = new System.Drawing.Point(0, 0);
            this.treeOrig.Name = "treeOrig";
            this.treeOrig.Size = new System.Drawing.Size(445, 362);
            this.treeOrig.TabIndex = 5;
            this.treeOrig.Text = "radTreeView1";
            this.treeOrig.ThemeName = "VisualStudio2012Light";
            this.treeOrig.TriStateMode = true;
            this.treeOrig.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.treeOrig_NodeCheckedChanged);
            // 
            // splitPanel6
            // 
            this.splitPanel6.Controls.Add(this.radLabel3);
            this.splitPanel6.Controls.Add(this.btnGenerate);
            this.splitPanel6.Controls.Add(this.btnCopy);
            this.splitPanel6.Controls.Add(this.btnExecute);
            this.splitPanel6.Location = new System.Drawing.Point(448, 0);
            this.splitPanel6.Name = "splitPanel6";
            // 
            // 
            // 
            this.splitPanel6.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel6.Size = new System.Drawing.Size(91, 362);
            this.splitPanel6.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.2416999F, 0F);
            this.splitPanel6.SizeInfo.SplitterCorrection = new System.Drawing.Size(-182, 0);
            this.splitPanel6.TabIndex = 1;
            this.splitPanel6.TabStop = false;
            this.splitPanel6.Text = "splitPanel6";
            this.splitPanel6.ThemeName = "VisualStudio2012Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.splitPanel6.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // btnGenerate
            // 
            this.btnGenerate.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.Location = new System.Drawing.Point(0, 227);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 45);
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
            this.btnCopy.Location = new System.Drawing.Point(0, 272);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(91, 45);
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
            this.btnExecute.Location = new System.Drawing.Point(0, 317);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(91, 45);
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
            this.splitPanel7.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel7.Size = new System.Drawing.Size(455, 362);
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
            this.treeDest.Size = new System.Drawing.Size(455, 362);
            this.treeDest.TabIndex = 6;
            this.treeDest.Text = "radTreeView1";
            this.treeDest.ThemeName = "VisualStudio2012Light";
            this.treeDest.TriStateMode = true;
            this.treeDest.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.treeDest_NodeCheckedChanged);
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.radLabel1);
            this.splitPanel3.Location = new System.Drawing.Point(0, 416);
            this.splitPanel3.Name = "splitPanel3";
            this.splitPanel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // 
            // 
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel3.Size = new System.Drawing.Size(1007, 27);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.2067308F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -86);
            this.splitPanel3.TabIndex = 2;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            this.splitPanel3.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radLabel1.Location = new System.Drawing.Point(0, 5);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 22);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Query result";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // splitPanel4
            // 
            this.splitPanel4.Controls.Add(this.txtResult);
            this.splitPanel4.Location = new System.Drawing.Point(0, 446);
            this.splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            this.splitPanel4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel4.Size = new System.Drawing.Size(1007, 187);
            this.splitPanel4.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.04967949F);
            this.splitPanel4.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 32);
            this.splitPanel4.TabIndex = 3;
            this.splitPanel4.TabStop = false;
            this.splitPanel4.Text = "splitPanel4";
            this.splitPanel4.ThemeName = "VisualStudio2012Light";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = false;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(1007, 187);
            this.txtResult.TabIndex = 0;
            // 
            // btnToggleFK
            // 
            this.btnToggleFK.DisplayStyle = Telerik.WinControls.DisplayStyle.Text;
            this.btnToggleFK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggleFK.Enabled = false;
            this.btnToggleFK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleFK.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToggleFK.Location = new System.Drawing.Point(650, 0);
            this.btnToggleFK.Name = "btnToggleFK";
            this.btnToggleFK.Size = new System.Drawing.Size(157, 38);
            this.btnToggleFK.TabIndex = 6;
            this.btnToggleFK.Text = "Toggle FK (Enabled)";
            this.btnToggleFK.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.radLabel3.Location = new System.Drawing.Point(0, 204);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(96, 23);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "------------->";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel3.ThemeName = "VisualStudio2012Light";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 633);
            this.Controls.Add(this.radSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Migration Tool PostgreSQL - Optimized for Odoo";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.btnSetSourceServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadDestinationTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSourceTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer2)).EndInit();
            this.radSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel5)).EndInit();
            this.splitPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel6)).EndInit();
            this.splitPanel6.ResumeLayout(false);
            this.splitPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel7)).EndInit();
            this.splitPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            this.splitPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).EndInit();
            this.splitPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleFK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSetSourceServer;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadTreeView treeOrig;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private Telerik.WinControls.UI.RadButton loadDestinationTables;
        private Telerik.WinControls.UI.RadButton loadSourceTables;
        private Telerik.WinControls.UI.RadTextBox txtResult;
        private Telerik.WinControls.UI.SplitPanel splitPanel4;
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
        private Telerik.WinControls.UI.RadButton btnToggleFK;
        private Telerik.WinControls.UI.RadLabel radLabel3;

    }
}