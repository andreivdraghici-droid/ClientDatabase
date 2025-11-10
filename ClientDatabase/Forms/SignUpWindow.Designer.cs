namespace ClientDatabase
{
    partial class SignUpWindow
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxClientPassword = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxClientEmail = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxClientCity = new System.Windows.Forms.TextBox();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.textBoxClientPostcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonConfirm.Location = new System.Drawing.Point(57, 248);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(112, 41);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "Confirma";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(139, 32);
            this.textBoxClientName.MaxLength = 20;
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientName.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCancel.Location = new System.Drawing.Point(203, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 41);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Anuleaza";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(43, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 18);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Nume";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPhone.Location = new System.Drawing.Point(43, 188);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 18);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Telefon";
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(139, 188);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientPhone.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAddress.Location = new System.Drawing.Point(43, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(54, 18);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Adresa";
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(139, 110);
            this.textBoxClientAddress.MaxLength = 50;
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientAddress.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPassword.Location = new System.Drawing.Point(43, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(50, 18);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Parola";
            // 
            // textBoxClientPassword
            // 
            this.textBoxClientPassword.Location = new System.Drawing.Point(139, 58);
            this.textBoxClientPassword.MaxLength = 20;
            this.textBoxClientPassword.Name = "textBoxClientPassword";
            this.textBoxClientPassword.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientPassword.TabIndex = 2;
            this.textBoxClientPassword.UseSystemPasswordChar = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.Location = new System.Drawing.Point(43, 84);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 18);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Location = new System.Drawing.Point(139, 84);
            this.textBoxClientEmail.MaxLength = 50;
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientEmail.TabIndex = 3;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCity.Location = new System.Drawing.Point(43, 136);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(39, 18);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "Oras";
            // 
            // textBoxClientCity
            // 
            this.textBoxClientCity.Location = new System.Drawing.Point(139, 136);
            this.textBoxClientCity.MaxLength = 50;
            this.textBoxClientCity.Name = "textBoxClientCity";
            this.textBoxClientCity.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientCity.TabIndex = 5;
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostcode.Location = new System.Drawing.Point(43, 162);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(79, 18);
            this.labelPostcode.TabIndex = 15;
            this.labelPostcode.Text = "Cod postal";
            // 
            // textBoxClientPostcode
            // 
            this.textBoxClientPostcode.Location = new System.Drawing.Point(139, 162);
            this.textBoxClientPostcode.Name = "textBoxClientPostcode";
            this.textBoxClientPostcode.Size = new System.Drawing.Size(188, 20);
            this.textBoxClientPostcode.TabIndex = 6;
            // 
            // SignUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 317);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.textBoxClientPostcode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxClientCity);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxClientEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxClientPassword);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxClientAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxClientPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "SignUpWindow";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxClientPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxClientEmail;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxClientCity;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.TextBox textBoxClientPostcode;
    }
}

