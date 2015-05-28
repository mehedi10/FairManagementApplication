namespace FairManagementApplication.UI
{
    partial class VisitorEntry
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
            this.grpVisitorInfo = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpWantedZoneTypeByVisitor = new System.Windows.Forms.GroupBox();
            this.chkLstZoneTypeByVisitor = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpVisitorInfo.SuspendLayout();
            this.grpWantedZoneTypeByVisitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVisitorInfo
            // 
            this.grpVisitorInfo.Controls.Add(this.txtContactNumber);
            this.grpVisitorInfo.Controls.Add(this.txtEmail);
            this.grpVisitorInfo.Controls.Add(this.txtName);
            this.grpVisitorInfo.Controls.Add(this.label3);
            this.grpVisitorInfo.Controls.Add(this.label2);
            this.grpVisitorInfo.Controls.Add(this.label1);
            this.grpVisitorInfo.Location = new System.Drawing.Point(64, 38);
            this.grpVisitorInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpVisitorInfo.Name = "grpVisitorInfo";
            this.grpVisitorInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpVisitorInfo.Size = new System.Drawing.Size(622, 158);
            this.grpVisitorInfo.TabIndex = 0;
            this.grpVisitorInfo.TabStop = false;
            this.grpVisitorInfo.Text = "Visitor\'s Information";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactNumber.Location = new System.Drawing.Point(179, 108);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(362, 21);
            this.txtContactNumber.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(179, 78);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 21);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(179, 48);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 21);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // grpWantedZoneTypeByVisitor
            // 
            this.grpWantedZoneTypeByVisitor.Controls.Add(this.chkLstZoneTypeByVisitor);
            this.grpWantedZoneTypeByVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWantedZoneTypeByVisitor.Location = new System.Drawing.Point(64, 217);
            this.grpWantedZoneTypeByVisitor.Margin = new System.Windows.Forms.Padding(4);
            this.grpWantedZoneTypeByVisitor.Name = "grpWantedZoneTypeByVisitor";
            this.grpWantedZoneTypeByVisitor.Padding = new System.Windows.Forms.Padding(4);
            this.grpWantedZoneTypeByVisitor.Size = new System.Drawing.Size(622, 283);
            this.grpWantedZoneTypeByVisitor.TabIndex = 1;
            this.grpWantedZoneTypeByVisitor.TabStop = false;
            this.grpWantedZoneTypeByVisitor.Text = "Zone Type Visitor Wants to Visit";
            // 
            // chkLstZoneTypeByVisitor
            // 
            this.chkLstZoneTypeByVisitor.CheckOnClick = true;
            this.chkLstZoneTypeByVisitor.FormattingEnabled = true;
            this.chkLstZoneTypeByVisitor.Location = new System.Drawing.Point(0, 21);
            this.chkLstZoneTypeByVisitor.Name = "chkLstZoneTypeByVisitor";
            this.chkLstZoneTypeByVisitor.Size = new System.Drawing.Size(622, 260);
            this.chkLstZoneTypeByVisitor.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(584, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // VisitorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 572);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpWantedZoneTypeByVisitor);
            this.Controls.Add(this.grpVisitorInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitorEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Entry";
            this.Load += new System.EventHandler(this.VisitorEntry_Load);
            this.grpVisitorInfo.ResumeLayout(false);
            this.grpVisitorInfo.PerformLayout();
            this.grpWantedZoneTypeByVisitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVisitorInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpWantedZoneTypeByVisitor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox chkLstZoneTypeByVisitor;
    }
}