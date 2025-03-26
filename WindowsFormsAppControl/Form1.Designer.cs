namespace WindowsFormsAppControl
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecordPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(23, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(156, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(220, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLabel.Location = new System.Drawing.Point(23, 64);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(74, 20);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EmailLabel.Location = new System.Drawing.Point(23, 90);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(111, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 116);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(23, 116);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecordPreview
            // 
            this.btnRecordPreview.Location = new System.Drawing.Point(156, 201);
            this.btnRecordPreview.Name = "btnRecordPreview";
            this.btnRecordPreview.Size = new System.Drawing.Size(220, 33);
            this.btnRecordPreview.TabIndex = 7;
            this.btnRecordPreview.Text = "Record Preview";
            this.btnRecordPreview.UseVisualStyleBackColor = true;
            this.btnRecordPreview.Click += new System.EventHandler(this.btnRecordPreview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.btnRecordPreview);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecordPreview;
    }
}

