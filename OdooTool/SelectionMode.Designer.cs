namespace OdooTool
{
    partial class SelectionMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionMode));
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radioAllTables = new Telerik.WinControls.UI.RadRadioButton();
            this.radioOneTable = new Telerik.WinControls.UI.RadRadioButton();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioAllTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioOneTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radioAllTables);
            this.radGroupBox1.Controls.Add(this.radioOneTable);
            this.radGroupBox1.HeaderText = "Select a option";
            this.radGroupBox1.Location = new System.Drawing.Point(71, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(175, 100);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Select a option";
            this.radGroupBox1.ThemeName = "VisualStudio2012Light";
            // 
            // radioAllTables
            // 
            this.radioAllTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAllTables.Location = new System.Drawing.Point(2, 51);
            this.radioAllTables.Name = "radioAllTables";
            this.radioAllTables.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.radioAllTables.Size = new System.Drawing.Size(96, 33);
            this.radioAllTables.TabIndex = 1;
            this.radioAllTables.TabStop = false;
            this.radioAllTables.Text = "Massive tables";
            this.radioAllTables.ThemeName = "VisualStudio2012Light";
            // 
            // radioOneTable
            // 
            this.radioOneTable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radioOneTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioOneTable.Location = new System.Drawing.Point(2, 18);
            this.radioOneTable.Name = "radioOneTable";
            this.radioOneTable.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.radioOneTable.Size = new System.Drawing.Size(93, 33);
            this.radioOneTable.TabIndex = 0;
            this.radioOneTable.Text = "Table by table";
            this.radioOneTable.ThemeName = "VisualStudio2012Light";
            this.radioOneTable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(108, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start mode";
            this.btnStart.ThemeName = "VisualStudio2012Light";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // SelectionMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 170);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionMode";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Migration Mode";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioAllTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioOneTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton radioAllTables;
        private Telerik.WinControls.UI.RadRadioButton radioOneTable;
        private Telerik.WinControls.UI.RadButton btnStart;
    }
}
