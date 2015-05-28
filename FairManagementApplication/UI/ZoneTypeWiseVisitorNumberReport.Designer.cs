namespace FairManagementApplication.UI
{
    partial class ZoneTypeWiseVisitorNumberReport
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
            this.lstTotalVisitorByZone = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalVisitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTotalVisitorByZone
            // 
            this.lstTotalVisitorByZone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstTotalVisitorByZone.FullRowSelect = true;
            this.lstTotalVisitorByZone.GridLines = true;
            this.lstTotalVisitorByZone.Location = new System.Drawing.Point(61, 29);
            this.lstTotalVisitorByZone.Name = "lstTotalVisitorByZone";
            this.lstTotalVisitorByZone.Size = new System.Drawing.Size(450, 230);
            this.lstTotalVisitorByZone.TabIndex = 0;
            this.lstTotalVisitorByZone.UseCompatibleStateImageBehavior = false;
            this.lstTotalVisitorByZone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 272;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No Of Visitor";
            this.columnHeader2.Width = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // txtTotalVisitor
            // 
            this.txtTotalVisitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVisitor.Location = new System.Drawing.Point(403, 283);
            this.txtTotalVisitor.Name = "txtTotalVisitor";
            this.txtTotalVisitor.Size = new System.Drawing.Size(108, 20);
            this.txtTotalVisitor.TabIndex = 2;
            this.txtTotalVisitor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ZoneTypeWiseVisitorNumberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 312);
            this.Controls.Add(this.txtTotalVisitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTotalVisitorByZone);
            this.Name = "ZoneTypeWiseVisitorNumberReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Type Wise Visitor Number Report";
            this.Load += new System.EventHandler(this.ZoneTypeWiseVisitorNumberReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTotalVisitorByZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalVisitor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}