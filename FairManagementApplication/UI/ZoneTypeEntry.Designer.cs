namespace FairManagementApplication.UI
{
    partial class ZoneTypeEntry
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
            this.grpZoneType = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstZoneType = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpZoneType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpZoneType
            // 
            this.grpZoneType.Controls.Add(this.btnSave);
            this.grpZoneType.Controls.Add(this.txtTypeName);
            this.grpZoneType.Controls.Add(this.label1);
            this.grpZoneType.Location = new System.Drawing.Point(49, 26);
            this.grpZoneType.Name = "grpZoneType";
            this.grpZoneType.Size = new System.Drawing.Size(383, 181);
            this.grpZoneType.TabIndex = 0;
            this.grpZoneType.TabStop = false;
            this.grpZoneType.Text = "Zone Type";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(251, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeName.Location = new System.Drawing.Point(135, 69);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(191, 20);
            this.txtTypeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // lstZoneType
            // 
            this.lstZoneType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstZoneType.FullRowSelect = true;
            this.lstZoneType.GridLines = true;
            this.lstZoneType.Location = new System.Drawing.Point(49, 225);
            this.lstZoneType.Name = "lstZoneType";
            this.lstZoneType.Size = new System.Drawing.Size(383, 181);
            this.lstZoneType.TabIndex = 1;
            this.lstZoneType.UseCompatibleStateImageBehavior = false;
            this.lstZoneType.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Type";
            this.columnHeader1.Width = 279;
            // 
            // ZoneTypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 422);
            this.Controls.Add(this.lstZoneType);
            this.Controls.Add(this.grpZoneType);
            this.Name = "ZoneTypeEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Type Entry";
            this.Load += new System.EventHandler(this.ZoneTypeEntry_Load);
            this.grpZoneType.ResumeLayout(false);
            this.grpZoneType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpZoneType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.ListView lstZoneType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}