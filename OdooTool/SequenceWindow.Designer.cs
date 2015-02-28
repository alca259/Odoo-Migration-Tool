namespace OdooTool
{
    partial class SequenceWindow
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SequenceWindow));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.HeaderPanel = new Telerik.WinControls.UI.SplitPanel();
            this.btnSetDestinationServer = new Telerik.WinControls.UI.RadButton();
            this.TablesPanel = new Telerik.WinControls.UI.SplitPanel();
            this.gridFields = new Telerik.WinControls.UI.RadGridView();
            this.btnExecute = new Telerik.WinControls.UI.RadButton();
            this.ProgressPanel = new Telerik.WinControls.UI.SplitPanel();
            this.progressBarResult = new Telerik.WinControls.UI.RadProgressBar();
            this.LabelsQuery = new Telerik.WinControls.UI.SplitPanel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ResultQueryPanel = new Telerik.WinControls.UI.SplitPanel();
            this.txtResult = new Telerik.WinControls.UI.RadTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablesPanel)).BeginInit();
            this.TablesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPanel)).BeginInit();
            this.ProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsQuery)).BeginInit();
            this.LabelsQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultQueryPanel)).BeginInit();
            this.ResultQueryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.HeaderPanel);
            this.radSplitContainer1.Controls.Add(this.TablesPanel);
            this.radSplitContainer1.Controls.Add(this.ProgressPanel);
            this.radSplitContainer1.Controls.Add(this.LabelsQuery);
            this.radSplitContainer1.Controls.Add(this.ResultQueryPanel);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radSplitContainer1.Size = new System.Drawing.Size(767, 521);
            this.radSplitContainer1.SplitterWidth = 3;
            this.radSplitContainer1.TabIndex = 5;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "VisualStudio2012Light";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.btnExecute);
            this.HeaderPanel.Controls.Add(this.btnRefresh);
            this.HeaderPanel.Controls.Add(this.btnSetDestinationServer);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            // 
            // 
            // 
            this.HeaderPanel.RootElement.MaxSize = new System.Drawing.Size(0, 60);
            this.HeaderPanel.RootElement.MinSize = new System.Drawing.Size(0, 60);
            this.HeaderPanel.Size = new System.Drawing.Size(767, 40);
            this.HeaderPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1019417F);
            this.HeaderPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 40);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.TabStop = false;
            this.HeaderPanel.Text = "splitPanel1";
            this.HeaderPanel.ThemeName = "VisualStudio2012Light";
            // 
            // btnSetDestinationServer
            // 
            this.btnSetDestinationServer.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.btnSetDestinationServer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetDestinationServer.Image = global::OdooTool.Properties.Resources.tool_icon;
            this.btnSetDestinationServer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSetDestinationServer.Location = new System.Drawing.Point(724, 0);
            this.btnSetDestinationServer.Name = "btnSetDestinationServer";
            this.btnSetDestinationServer.Size = new System.Drawing.Size(43, 40);
            this.btnSetDestinationServer.TabIndex = 5;
            this.btnSetDestinationServer.ThemeName = "VisualStudio2012Light";
            this.btnSetDestinationServer.Click += new System.EventHandler(this.btnSetDestinationServer_Click);
            // 
            // TablesPanel
            // 
            this.TablesPanel.Controls.Add(this.gridFields);
            this.TablesPanel.Location = new System.Drawing.Point(0, 43);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.TablesPanel.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.TablesPanel.Size = new System.Drawing.Size(767, 259);
            this.TablesPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.2783172F);
            this.TablesPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -203);
            this.TablesPanel.TabIndex = 1;
            this.TablesPanel.TabStop = false;
            this.TablesPanel.Text = "splitPanel2";
            this.TablesPanel.ThemeName = "VisualStudio2012Light";
            // 
            // gridFields
            // 
            this.gridFields.AutoSizeRows = true;
            this.gridFields.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.gridFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFields.EnableHotTracking = false;
            this.gridFields.Location = new System.Drawing.Point(5, 5);
            // 
            // gridFields
            // 
            this.gridFields.MasterTemplate.AllowAddNewRow = false;
            this.gridFields.MasterTemplate.AllowColumnChooser = false;
            this.gridFields.MasterTemplate.AllowColumnReorder = false;
            this.gridFields.MasterTemplate.AllowDeleteRow = false;
            this.gridFields.MasterTemplate.AllowDragToGroup = false;
            this.gridFields.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridFields.MasterTemplate.EnableAlternatingRowColor = true;
            this.gridFields.MasterTemplate.EnableFiltering = true;
            this.gridFields.MasterTemplate.EnableGrouping = false;
            this.gridFields.MasterTemplate.MultiSelect = true;
            sortDescriptor1.PropertyName = "idCol";
            sortDescriptor2.PropertyName = "column1";
            this.gridFields.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1,
            sortDescriptor2});
            this.gridFields.Name = "gridFields";
            this.gridFields.Size = new System.Drawing.Size(757, 249);
            this.gridFields.TabIndex = 0;
            this.gridFields.Text = "radGridView1";
            // 
            // btnExecute
            // 
            this.btnExecute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExecute.Image = global::OdooTool.Properties.Resources.run_icon;
            this.btnExecute.Location = new System.Drawing.Point(128, 0);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExecute.Size = new System.Drawing.Size(169, 40);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Alter sequences to max";
            this.btnExecute.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.ThemeName = "VisualStudio2012Light";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Controls.Add(this.progressBarResult);
            this.ProgressPanel.Location = new System.Drawing.Point(0, 305);
            this.ProgressPanel.Name = "ProgressPanel";
            // 
            // 
            // 
            this.ProgressPanel.RootElement.MaxSize = new System.Drawing.Size(0, 30);
            this.ProgressPanel.RootElement.MinSize = new System.Drawing.Size(0, 30);
            this.ProgressPanel.Size = new System.Drawing.Size(767, 30);
            this.ProgressPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.118123F);
            this.ProgressPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 30);
            this.ProgressPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 30);
            this.ProgressPanel.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 106);
            this.ProgressPanel.TabIndex = 3;
            this.ProgressPanel.TabStop = false;
            this.ProgressPanel.Text = "splitPanel4";
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
            this.progressBarResult.Size = new System.Drawing.Size(767, 30);
            this.progressBarResult.Step = 1;
            this.progressBarResult.StepWidth = 30;
            this.progressBarResult.SweepAngle = 60;
            this.progressBarResult.TabIndex = 6;
            this.progressBarResult.TabStop = false;
            this.progressBarResult.Text = "0 %";
            this.progressBarResult.ThemeName = "VisualStudio2012Light";
            // 
            // LabelsQuery
            // 
            this.LabelsQuery.Controls.Add(this.btnClear);
            this.LabelsQuery.Controls.Add(this.radLabel1);
            this.LabelsQuery.Location = new System.Drawing.Point(0, 338);
            this.LabelsQuery.Name = "LabelsQuery";
            // 
            // 
            // 
            this.LabelsQuery.RootElement.MaxSize = new System.Drawing.Size(0, 30);
            this.LabelsQuery.RootElement.MinSize = new System.Drawing.Size(0, 30);
            this.LabelsQuery.Size = new System.Drawing.Size(767, 30);
            this.LabelsQuery.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.118123F);
            this.LabelsQuery.SizeInfo.MaximumSize = new System.Drawing.Size(0, 30);
            this.LabelsQuery.SizeInfo.MinimumSize = new System.Drawing.Size(0, 30);
            this.LabelsQuery.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -82);
            this.LabelsQuery.TabIndex = 4;
            this.LabelsQuery.TabStop = false;
            this.LabelsQuery.Text = "splitPanel8";
            this.LabelsQuery.ThemeName = "VisualStudio2012Light";
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Image = global::OdooTool.Properties.Resources.clear_icon;
            this.btnClear.Location = new System.Drawing.Point(701, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(66, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.ThemeName = "VisualStudio2012Light";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 30);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Query result";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            // 
            // ResultQueryPanel
            // 
            this.ResultQueryPanel.Controls.Add(this.txtResult);
            this.ResultQueryPanel.Location = new System.Drawing.Point(0, 371);
            this.ResultQueryPanel.Name = "ResultQueryPanel";
            // 
            // 
            // 
            this.ResultQueryPanel.RootElement.MaxSize = new System.Drawing.Size(0, 150);
            this.ResultQueryPanel.RootElement.MinSize = new System.Drawing.Size(0, 150);
            this.ResultQueryPanel.Size = new System.Drawing.Size(767, 150);
            this.ResultQueryPanel.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.07605177F);
            this.ResultQueryPanel.SizeInfo.MaximumSize = new System.Drawing.Size(0, 150);
            this.ResultQueryPanel.SizeInfo.MinimumSize = new System.Drawing.Size(0, 150);
            this.ResultQueryPanel.TabIndex = 5;
            this.ResultQueryPanel.TabStop = false;
            this.ResultQueryPanel.Text = "splitPanel1";
            this.ResultQueryPanel.ThemeName = "VisualStudio2012Light";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = false;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(767, 150);
            this.txtResult.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.FileName = "export";
            this.saveFileDialog1.Filter = "Archivo SQL|*.sql|Todos los archivos|*.*";
            this.saveFileDialog1.Title = "Save data";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Image = global::OdooTool.Properties.Resources.reload_icon;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnRefresh.Size = new System.Drawing.Size(128, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Load sequences";
            this.btnRefresh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.ThemeName = "VisualStudio2012Light";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SequenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 521);
            this.Controls.Add(this.radSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SequenceWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Migration Tool PostgreSQL - Optimized for Odoo";
            this.ThemeName = "VisualStudio2012Light";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSetDestinationServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablesPanel)).EndInit();
            this.TablesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFields.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPanel)).EndInit();
            this.ProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelsQuery)).EndInit();
            this.LabelsQuery.ResumeLayout(false);
            this.LabelsQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultQueryPanel)).EndInit();
            this.ResultQueryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel HeaderPanel;
        private Telerik.WinControls.UI.SplitPanel TablesPanel;
        private Telerik.WinControls.UI.RadTextBox txtResult;
        private Telerik.WinControls.UI.SplitPanel ProgressPanel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnSetDestinationServer;
        private Telerik.WinControls.UI.SplitPanel LabelsQuery;
        private Telerik.WinControls.UI.RadProgressBar progressBarResult;
        private Telerik.WinControls.UI.RadGridView gridFields;
        private Telerik.WinControls.UI.SplitPanel ResultQueryPanel;
        private Telerik.WinControls.UI.RadButton btnExecute;
        private Telerik.WinControls.UI.RadButton btnClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Telerik.WinControls.UI.RadButton btnRefresh;

    }
}