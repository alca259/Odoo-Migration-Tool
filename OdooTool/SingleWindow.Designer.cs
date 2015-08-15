using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using OdooTool.Properties;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace OdooTool
{
    public partial class SingleWindow : RadForm
    {
        #region Designer zone
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SortDescriptor sortDescriptor1 = new SortDescriptor();
            SortDescriptor sortDescriptor2 = new SortDescriptor();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SingleWindow));
            this.btnSetSourceServer = new RadButton();
            this.visualStudio2012LightTheme1 = new VisualStudio2012LightTheme();
            this.radSplitContainer1 = new RadSplitContainer();
            this.HeaderPanel = new SplitPanel();
            this.srcTableDropdown = new RadDropDownList();
            this.refreshButton = new RadButton();
            this.radLabel2 = new RadLabel();
            this.btnSetDestinationServer = new RadButton();
            this.TablesPanel = new SplitPanel();
            this.gridFields = new RadGridView();
            this.ButtonsQueryPanel = new SplitPanel();
            this.btnSaveSQL = new RadButton();
            this.btnExecute = new RadButton();
            this.btnEnableConst = new RadButton();
            this.btnDisableConst = new RadButton();
            this.ProgressPanel = new SplitPanel();
            this.progressBarResult = new RadProgressBar();
            this.LabelsQuery = new SplitPanel();
            this.btnClear = new RadButton();
            this.radLabel1 = new RadLabel();
            this.ResultQueryPanel = new SplitPanel();
            this.txtResult = new RadTextBox();
            this.saveFileDialog1 = new SaveFileDialog();
            this.btnToggleSelect = new RadButton();
            this.btnSetSourceServer.BeginInit();
            this.radSplitContainer1.BeginInit();
            this.radSplitContainer1.SuspendLayout();
            this.HeaderPanel.BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.srcTableDropdown.BeginInit();
            this.refreshButton.BeginInit();
            this.radLabel2.BeginInit();
            this.btnSetDestinationServer.BeginInit();
            this.TablesPanel.BeginInit();
            this.TablesPanel.SuspendLayout();
            this.gridFields.BeginInit();
            this.gridFields.MasterTemplate.BeginInit();
            this.ButtonsQueryPanel.BeginInit();
            this.ButtonsQueryPanel.SuspendLayout();
            this.btnSaveSQL.BeginInit();
            this.btnExecute.BeginInit();
            this.btnEnableConst.BeginInit();
            this.btnDisableConst.BeginInit();
            this.ProgressPanel.BeginInit();
            this.ProgressPanel.SuspendLayout();
            this.progressBarResult.BeginInit();
            this.LabelsQuery.BeginInit();
            this.LabelsQuery.SuspendLayout();
            this.btnClear.BeginInit();
            this.radLabel1.BeginInit();
            this.ResultQueryPanel.BeginInit();
            this.ResultQueryPanel.SuspendLayout();
            this.txtResult.BeginInit();
            this.btnToggleSelect.BeginInit();
            this.BeginInit();
            this.SuspendLayout();
            this.btnSetSourceServer.DisplayStyle = DisplayStyle.Image;
            this.btnSetSourceServer.Dock = DockStyle.Left;
            this.btnSetSourceServer.Image = (Image)Resources.tool_icon;
            this.btnSetSourceServer.ImageAlignment = ContentAlignment.MiddleCenter;
            this.btnSetSourceServer.Location = new Point(0, 20);
            this.btnSetSourceServer.Name = "btnSetSourceServer";
            this.btnSetSourceServer.Size = new Size(43, 40);
            this.btnSetSourceServer.TabIndex = 2;
            this.btnSetSourceServer.ThemeName = "VisualStudio2012Light";
            this.btnSetSourceServer.Click += new EventHandler(this.btnSetSourceServer_Click);
            this.radSplitContainer1.Controls.Add((Control)this.HeaderPanel);
            this.radSplitContainer1.Controls.Add((Control)this.TablesPanel);
            this.radSplitContainer1.Controls.Add((Control)this.ButtonsQueryPanel);
            this.radSplitContainer1.Controls.Add((Control)this.ProgressPanel);
            this.radSplitContainer1.Controls.Add((Control)this.LabelsQuery);
            this.radSplitContainer1.Controls.Add((Control)this.ResultQueryPanel);
            this.radSplitContainer1.Dock = DockStyle.Fill;
            this.radSplitContainer1.Location = new Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = Orientation.Horizontal;
            this.radSplitContainer1.RootElement.MinSize = new Size(0, 0);
            this.radSplitContainer1.Size = new Size(767, 633);
            this.radSplitContainer1.SplitterWidth = 3;
            this.radSplitContainer1.TabIndex = 5;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "VisualStudio2012Light";
            this.HeaderPanel.Controls.Add((Control)this.srcTableDropdown);
            this.HeaderPanel.Controls.Add((Control)this.refreshButton);
            this.HeaderPanel.Controls.Add((Control)this.radLabel2);
            this.HeaderPanel.Controls.Add((Control)this.btnSetDestinationServer);
            this.HeaderPanel.Controls.Add((Control)this.btnSetSourceServer);
            this.HeaderPanel.Location = new Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Padding = new Padding(0, 20, 0, 0);
            this.HeaderPanel.RootElement.MaxSize = new Size(0, 60);
            this.HeaderPanel.RootElement.MinSize = new Size(0, 60);
            this.HeaderPanel.Size = new Size(767, 60);
            this.HeaderPanel.SizeInfo.AutoSizeScale = new SizeF(0.0f, -0.1355878f);
            this.HeaderPanel.SizeInfo.MaximumSize = new Size(0, 60);
            this.HeaderPanel.SizeInfo.MinimumSize = new Size(0, 60);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.TabStop = false;
            this.HeaderPanel.Text = "splitPanel1";
            this.HeaderPanel.ThemeName = "VisualStudio2012Light";
            this.srcTableDropdown.Dock = DockStyle.Fill;
            this.srcTableDropdown.Location = new Point(118, 20);
            this.srcTableDropdown.Name = "srcTableDropdown";
            this.srcTableDropdown.Size = new Size(563, 40);
            this.srcTableDropdown.TabIndex = 0;
            this.srcTableDropdown.ThemeName = "VisualStudio2012Light";
            this.srcTableDropdown.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.srcTableDropdown_SelectedIndexChanged);
            this.refreshButton.DisplayStyle = DisplayStyle.Image;
            this.refreshButton.Dock = DockStyle.Right;
            this.refreshButton.Image = (Image)Resources.reload_icon;
            this.refreshButton.ImageAlignment = ContentAlignment.MiddleCenter;
            this.refreshButton.Location = new Point(681, 20);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new Size(43, 40);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.ThemeName = "VisualStudio2012Light";
            this.refreshButton.Click += new EventHandler(this.refreshButton_Click);
            this.radLabel2.Dock = DockStyle.Left;
            this.radLabel2.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold);
            this.radLabel2.Location = new Point(43, 20);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new Size(75, 40);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Source Table";
            this.radLabel2.ThemeName = "VisualStudio2012Light";
            this.btnSetDestinationServer.DisplayStyle = DisplayStyle.Image;
            this.btnSetDestinationServer.Dock = DockStyle.Right;
            this.btnSetDestinationServer.Image = (Image)Resources.tool_icon;
            this.btnSetDestinationServer.ImageAlignment = ContentAlignment.MiddleCenter;
            this.btnSetDestinationServer.Location = new Point(724, 20);
            this.btnSetDestinationServer.Name = "btnSetDestinationServer";
            this.btnSetDestinationServer.Size = new Size(43, 40);
            this.btnSetDestinationServer.TabIndex = 5;
            this.btnSetDestinationServer.ThemeName = "VisualStudio2012Light";
            this.btnSetDestinationServer.Click += new EventHandler(this.btnSetDestinationServer_Click);
            this.TablesPanel.Controls.Add((Control)this.gridFields);
            this.TablesPanel.Location = new Point(0, 63);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Padding = new Padding(5);
            this.TablesPanel.RootElement.MinSize = new Size(0, 0);
            this.TablesPanel.Size = new Size(767, 308);
            this.TablesPanel.SizeInfo.AutoSizeScale = new SizeF(0.0f, 0.1494364f);
            this.TablesPanel.SizeInfo.SplitterCorrection = new Size(0, -72);
            this.TablesPanel.TabIndex = 1;
            this.TablesPanel.TabStop = false;
            this.TablesPanel.Text = "splitPanel2";
            this.TablesPanel.ThemeName = "VisualStudio2012Light";
            this.gridFields.AutoSizeRows = true;
            this.gridFields.BeginEditMode = RadGridViewBeginEditMode.BeginEditProgrammatically;
            this.gridFields.Dock = DockStyle.Fill;
            this.gridFields.EnableHotTracking = false;
            this.gridFields.Location = new Point(5, 5);
            this.gridFields.MasterTemplate.AllowAddNewRow = false;
            this.gridFields.MasterTemplate.AllowColumnChooser = false;
            this.gridFields.MasterTemplate.AllowColumnReorder = false;
            this.gridFields.MasterTemplate.AllowDeleteRow = false;
            this.gridFields.MasterTemplate.AllowDragToGroup = false;
            this.gridFields.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.gridFields.MasterTemplate.EnableAlternatingRowColor = true;
            this.gridFields.MasterTemplate.EnableFiltering = true;
            this.gridFields.MasterTemplate.EnableGrouping = false;
            this.gridFields.MasterTemplate.MultiSelect = true;
            sortDescriptor1.PropertyName = "idCol";
            sortDescriptor2.PropertyName = "column1";
            this.gridFields.MasterTemplate.SortDescriptors.AddRange(sortDescriptor1, sortDescriptor2);
            this.gridFields.Name = "gridFields";
            this.gridFields.Size = new Size(757, 298);
            this.gridFields.TabIndex = 0;
            this.gridFields.Text = "radGridView1";
            this.ButtonsQueryPanel.Controls.Add((Control)this.btnToggleSelect);
            this.ButtonsQueryPanel.Controls.Add((Control)this.btnSaveSQL);
            this.ButtonsQueryPanel.Controls.Add((Control)this.btnExecute);
            this.ButtonsQueryPanel.Controls.Add((Control)this.btnEnableConst);
            this.ButtonsQueryPanel.Controls.Add((Control)this.btnDisableConst);
            this.ButtonsQueryPanel.Location = new Point(0, 374);
            this.ButtonsQueryPanel.Name = "ButtonsQueryPanel";
            this.ButtonsQueryPanel.Padding = new Padding(0, 5, 0, 0);
            this.ButtonsQueryPanel.RootElement.MaxSize = new Size(0, 40);
            this.ButtonsQueryPanel.RootElement.MinSize = new Size(0, 40);
            this.ButtonsQueryPanel.Size = new Size(767, 40);
            this.ButtonsQueryPanel.SizeInfo.AutoSizeScale = new SizeF(0.0f, -0.1533011f);
            this.ButtonsQueryPanel.SizeInfo.MaximumSize = new Size(0, 40);
            this.ButtonsQueryPanel.SizeInfo.MinimumSize = new Size(0, 40);
            this.ButtonsQueryPanel.SizeInfo.SplitterCorrection = new Size(0, 124);
            this.ButtonsQueryPanel.TabIndex = 2;
            this.ButtonsQueryPanel.TabStop = false;
            this.ButtonsQueryPanel.Text = "splitPanel3";
            this.ButtonsQueryPanel.ThemeName = "VisualStudio2012Light";
            this.btnSaveSQL.Dock = DockStyle.Right;
            this.btnSaveSQL.Image = (Image)Resources.copy_icon;
            this.btnSaveSQL.Location = new Point(581, 5);
            this.btnSaveSQL.Name = "btnSaveSQL";
            this.btnSaveSQL.Padding = new Padding(5, 0, 5, 0);
            this.btnSaveSQL.Size = new Size(100, 35);
            this.btnSaveSQL.TabIndex = 6;
            this.btnSaveSQL.Text = "Save to file";
            this.btnSaveSQL.TextAlignment = ContentAlignment.MiddleRight;
            this.btnSaveSQL.ThemeName = "VisualStudio2012Light";
            this.btnSaveSQL.Click += new EventHandler(this.btnSaveSQL_Click);
            this.btnExecute.Dock = DockStyle.Right;
            this.btnExecute.Image = (Image)Resources.run_icon;
            this.btnExecute.Location = new Point(681, 5);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Padding = new Padding(5, 0, 5, 0);
            this.btnExecute.Size = new Size(86, 35);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.TextAlignment = ContentAlignment.MiddleRight;
            this.btnExecute.ThemeName = "VisualStudio2012Light";
            this.btnExecute.Click += new EventHandler(this.btnExecute_Click);
            this.btnEnableConst.Dock = DockStyle.Left;
            this.btnEnableConst.Image = (Image)Resources.enable_icon;
            this.btnEnableConst.Location = new Point(136, 5);
            this.btnEnableConst.Name = "btnEnableConst";
            this.btnEnableConst.Padding = new Padding(5, 0, 5, 0);
            this.btnEnableConst.Size = new Size(136, 35);
            this.btnEnableConst.TabIndex = 4;
            this.btnEnableConst.Text = "Enable constraints";
            this.btnEnableConst.TextAlignment = ContentAlignment.MiddleRight;
            this.btnEnableConst.ThemeName = "VisualStudio2012Light";
            this.btnEnableConst.Click += new EventHandler(this.btnEnableConst_Click);
            this.btnDisableConst.Dock = DockStyle.Left;
            this.btnDisableConst.Image = (Image)Resources.disable_icon;
            this.btnDisableConst.Location = new Point(0, 5);
            this.btnDisableConst.Name = "btnDisableConst";
            this.btnDisableConst.Padding = new Padding(5, 0, 5, 0);
            this.btnDisableConst.Size = new Size(136, 35);
            this.btnDisableConst.TabIndex = 3;
            this.btnDisableConst.Text = "Disable constraints";
            this.btnDisableConst.TextAlignment = ContentAlignment.MiddleRight;
            this.btnDisableConst.ThemeName = "VisualStudio2012Light";
            this.btnDisableConst.Click += new EventHandler(this.btnDisableConst_Click);
            this.ProgressPanel.Controls.Add((Control)this.progressBarResult);
            this.ProgressPanel.Location = new Point(0, 417);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.RootElement.MaxSize = new Size(0, 30);
            this.ProgressPanel.RootElement.MinSize = new Size(0, 30);
            this.ProgressPanel.Size = new Size(767, 30);
            this.ProgressPanel.SizeInfo.AutoSizeScale = new SizeF(0.0f, 0.27343f);
            this.ProgressPanel.SizeInfo.MaximumSize = new Size(0, 30);
            this.ProgressPanel.SizeInfo.MinimumSize = new Size(0, 30);
            this.ProgressPanel.SizeInfo.SplitterCorrection = new Size(0, 106);
            this.ProgressPanel.TabIndex = 3;
            this.ProgressPanel.TabStop = false;
            this.ProgressPanel.Text = "splitPanel4";
            this.ProgressPanel.ThemeName = "VisualStudio2012Light";
            this.progressBarResult.Dock = DockStyle.Fill;
            this.progressBarResult.Location = new Point(0, 0);
            this.progressBarResult.Name = "progressBarResult";
            this.progressBarResult.SeparatorGradientAngle = 4;
            this.progressBarResult.SeparatorWidth = 5;
            this.progressBarResult.ShowProgressIndicators = true;
            this.progressBarResult.Size = new Size(767, 30);
            this.progressBarResult.Step = 1;
            this.progressBarResult.StepWidth = 30;
            this.progressBarResult.SweepAngle = 60;
            this.progressBarResult.TabIndex = 6;
            this.progressBarResult.TabStop = false;
            this.progressBarResult.Text = "0 %";
            this.progressBarResult.ThemeName = "VisualStudio2012Light";
            this.LabelsQuery.Controls.Add((Control)this.btnClear);
            this.LabelsQuery.Controls.Add((Control)this.radLabel1);
            this.LabelsQuery.Location = new Point(0, 450);
            this.LabelsQuery.Name = "LabelsQuery";
            this.LabelsQuery.RootElement.MaxSize = new Size(0, 30);
            this.LabelsQuery.RootElement.MinSize = new Size(0, 30);
            this.LabelsQuery.Size = new Size(767, 30);
            this.LabelsQuery.SizeInfo.AutoSizeScale = new SizeF(0.0f, -0.1355878f);
            this.LabelsQuery.SizeInfo.MaximumSize = new Size(0, 30);
            this.LabelsQuery.SizeInfo.MinimumSize = new Size(0, 30);
            this.LabelsQuery.SizeInfo.SplitterCorrection = new Size(0, -82);
            this.LabelsQuery.TabIndex = 4;
            this.LabelsQuery.TabStop = false;
            this.LabelsQuery.Text = "splitPanel8";
            this.LabelsQuery.ThemeName = "VisualStudio2012Light";
            this.btnClear.Dock = DockStyle.Right;
            this.btnClear.Image = (Image)Resources.clear_icon;
            this.btnClear.Location = new Point(701, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new Padding(5, 0, 5, 0);
            this.btnClear.Size = new Size(66, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlignment = ContentAlignment.MiddleRight;
            this.btnClear.ThemeName = "VisualStudio2012Light";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.radLabel1.Dock = DockStyle.Left;
            this.radLabel1.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold | FontStyle.Italic);
            this.radLabel1.Location = new Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new Size(71, 30);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Query result";
            this.radLabel1.ThemeName = "VisualStudio2012Light";
            this.ResultQueryPanel.Controls.Add((Control)this.txtResult);
            this.ResultQueryPanel.Location = new Point(0, 483);
            this.ResultQueryPanel.Name = "ResultQueryPanel";
            this.ResultQueryPanel.RootElement.MaxSize = new Size(0, 150);
            this.ResultQueryPanel.RootElement.MinSize = new Size(0, 150);
            this.ResultQueryPanel.Size = new Size(767, 150);
            this.ResultQueryPanel.SizeInfo.MaximumSize = new Size(0, 150);
            this.ResultQueryPanel.SizeInfo.MinimumSize = new Size(0, 150);
            this.ResultQueryPanel.TabIndex = 5;
            this.ResultQueryPanel.TabStop = false;
            this.ResultQueryPanel.Text = "splitPanel1";
            this.ResultQueryPanel.ThemeName = "VisualStudio2012Light";
            this.txtResult.AutoSize = false;
            this.txtResult.Dock = DockStyle.Fill;
            this.txtResult.Location = new Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = ScrollBars.Vertical;
            this.txtResult.Size = new Size(767, 150);
            this.txtResult.TabIndex = 0;
            this.saveFileDialog1.DefaultExt = "sql";
            this.saveFileDialog1.FileName = "export";
            this.saveFileDialog1.Filter = "Archivo SQL|*.sql|Todos los archivos|*.*";
            this.saveFileDialog1.Title = "Save data";
            this.btnToggleSelect.Dock = DockStyle.Left;
            this.btnToggleSelect.Image = (Image)Resources.tool_icon;
            this.btnToggleSelect.Location = new Point(272, 5);
            this.btnToggleSelect.Name = "btnToggleSelect";
            this.btnToggleSelect.Padding = new Padding(5, 0, 5, 0);
            this.btnToggleSelect.Size = new Size(116, 35);
            this.btnToggleSelect.TabIndex = 7;
            this.btnToggleSelect.Text = "Un/Select All";
            this.btnToggleSelect.TextAlignment = ContentAlignment.MiddleRight;
            this.btnToggleSelect.ThemeName = "VisualStudio2012Light";
            this.btnToggleSelect.Click += new EventHandler(this.btnToggleSelect_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(767, 633);
            this.Controls.Add((Control)this.radSplitContainer1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.Name = "SingleWindow";
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Migration Tool PostgreSQL - Optimized for Odoo";
            this.ThemeName = "VisualStudio2012Light";
            this.WindowState = FormWindowState.Maximized;
            this.btnSetSourceServer.EndInit();
            this.radSplitContainer1.EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            this.HeaderPanel.EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.srcTableDropdown.EndInit();
            this.refreshButton.EndInit();
            this.radLabel2.EndInit();
            this.btnSetDestinationServer.EndInit();
            this.TablesPanel.EndInit();
            this.TablesPanel.ResumeLayout(false);
            this.gridFields.MasterTemplate.EndInit();
            this.gridFields.EndInit();
            this.ButtonsQueryPanel.EndInit();
            this.ButtonsQueryPanel.ResumeLayout(false);
            this.btnSaveSQL.EndInit();
            this.btnExecute.EndInit();
            this.btnEnableConst.EndInit();
            this.btnDisableConst.EndInit();
            this.ProgressPanel.EndInit();
            this.ProgressPanel.ResumeLayout(false);
            this.progressBarResult.EndInit();
            this.LabelsQuery.EndInit();
            this.LabelsQuery.ResumeLayout(false);
            this.LabelsQuery.PerformLayout();
            this.btnClear.EndInit();
            this.radLabel1.EndInit();
            this.ResultQueryPanel.EndInit();
            this.ResultQueryPanel.ResumeLayout(false);
            this.txtResult.EndInit();
            this.btnToggleSelect.EndInit();
            this.EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private IContainer components;
        private RadButton btnSetSourceServer;
        private VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private RadSplitContainer radSplitContainer1;
        private SplitPanel HeaderPanel;
        private SplitPanel TablesPanel;
        private SplitPanel ButtonsQueryPanel;
        private RadTextBox txtResult;
        private SplitPanel ProgressPanel;
        private RadLabel radLabel1;
        private RadButton btnSetDestinationServer;
        private SplitPanel LabelsQuery;
        private RadProgressBar progressBarResult;
        private RadLabel radLabel2;
        private RadDropDownList srcTableDropdown;
        private RadButton refreshButton;
        private RadGridView gridFields;
        private SplitPanel ResultQueryPanel;
        private RadButton btnEnableConst;
        private RadButton btnDisableConst;
        private RadButton btnExecute;
        private RadButton btnClear;
        private RadButton btnSaveSQL;
        private SaveFileDialog saveFileDialog1;
        private RadButton btnToggleSelect;
    }
}