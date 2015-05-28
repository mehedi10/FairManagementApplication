namespace FairManagementApplication.UI
{
    partial class ZoneSpecificVisitorInformationReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbAllZone = new System.Windows.Forms.ComboBox();
            this.lstVisitorByZoneType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalVisitorByZone = new System.Windows.Forms.TextBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(472, 41);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cmbAllZone
            // 
            this.cmbAllZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAllZone.FormattingEnabled = true;
            this.cmbAllZone.Location = new System.Drawing.Point(200, 43);
            this.cmbAllZone.Name = "cmbAllZone";
            this.cmbAllZone.Size = new System.Drawing.Size(263, 21);
            this.cmbAllZone.TabIndex = 3;
            // 
            // lstVisitorByZoneType
            // 
            this.lstVisitorByZoneType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstVisitorByZoneType.FullRowSelect = true;
            this.lstVisitorByZoneType.GridLines = true;
            this.lstVisitorByZoneType.Location = new System.Drawing.Point(46, 81);
            this.lstVisitorByZoneType.Name = "lstVisitorByZoneType";
            this.lstVisitorByZoneType.Size = new System.Drawing.Size(600, 269);
            this.lstVisitorByZoneType.TabIndex = 4;
            this.lstVisitorByZoneType.UseCompatibleStateImageBehavior = false;
            this.lstVisitorByZoneType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // txtTotalVisitorByZone
            // 
            this.txtTotalVisitorByZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVisitorByZone.Location = new System.Drawing.Point(519, 367);
            this.txtTotalVisitorByZone.Name = "txtTotalVisitorByZone";
            this.txtTotalVisitorByZone.Size = new System.Drawing.Size(127, 20);
            this.txtTotalVisitorByZone.TabIndex = 6;
            this.txtTotalVisitorByZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.Location = new System.Drawing.Point(510, 418);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(136, 23);
            this.btnExportToExcel.TabIndex = 7;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // ZoneSpecificVisitorInformationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.txtTotalVisitorByZone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstVisitorByZoneType);
            this.Controls.Add(this.cmbAllZone);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Specific Visitor Information Report";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorInformationReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbAllZone;
        private System.Windows.Forms.ListView lstVisitorByZoneType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalVisitorByZone;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}