namespace WindowsFormsAppControl
{
    partial class Add_Form_Record_Preview
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
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtPhoneForm2 = new System.Windows.Forms.TextBox();
            this.txtEmailForm2 = new System.Windows.Forms.TextBox();
            this.txtSurnameForm2 = new System.Windows.Forms.TextBox();
            this.txtNameForm2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(18, 113);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailLabel.Location = new System.Drawing.Point(18, 87);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(111, 20);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email Address";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLabel.Location = new System.Drawing.Point(18, 61);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(74, 20);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(18, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name";
            // 
            // txtPhoneForm2
            // 
            this.txtPhoneForm2.Enabled = false;
            this.txtPhoneForm2.Location = new System.Drawing.Point(151, 113);
            this.txtPhoneForm2.Name = "txtPhoneForm2";
            this.txtPhoneForm2.Size = new System.Drawing.Size(220, 20);
            this.txtPhoneForm2.TabIndex = 15;
            // 
            // txtEmailForm2
            // 
            this.txtEmailForm2.Enabled = false;
            this.txtEmailForm2.Location = new System.Drawing.Point(151, 87);
            this.txtEmailForm2.Name = "txtEmailForm2";
            this.txtEmailForm2.Size = new System.Drawing.Size(220, 20);
            this.txtEmailForm2.TabIndex = 14;
            // 
            // txtSurnameForm2
            // 
            this.txtSurnameForm2.Enabled = false;
            this.txtSurnameForm2.Location = new System.Drawing.Point(151, 61);
            this.txtSurnameForm2.Name = "txtSurnameForm2";
            this.txtSurnameForm2.Size = new System.Drawing.Size(220, 20);
            this.txtSurnameForm2.TabIndex = 13;
            // 
            // txtNameForm2
            // 
            this.txtNameForm2.Enabled = false;
            this.txtNameForm2.Location = new System.Drawing.Point(151, 35);
            this.txtNameForm2.Name = "txtNameForm2";
            this.txtNameForm2.Size = new System.Drawing.Size(220, 20);
            this.txtNameForm2.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 98);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Add_Form_Record_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 153);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.txtPhoneForm2);
            this.Controls.Add(this.txtEmailForm2);
            this.Controls.Add(this.txtSurnameForm2);
            this.Controls.Add(this.txtNameForm2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Form_Record_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Record Preview Form ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtPhoneForm2;
        private System.Windows.Forms.TextBox txtEmailForm2;
        private System.Windows.Forms.TextBox txtSurnameForm2;
        private System.Windows.Forms.TextBox txtNameForm2;
        private System.Windows.Forms.Button btnSave;
    }
}