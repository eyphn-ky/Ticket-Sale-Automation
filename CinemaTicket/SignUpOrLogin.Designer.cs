
namespace CinemaTicket
{
    partial class SignUpOrLogin
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
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.lblMailAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbxSignUpOrLogin = new System.Windows.Forms.GroupBox();
            this.txtCustomerMailAddress = new System.Windows.Forms.TextBox();
            this.chkVisiblePassword = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblBeCustomer = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbxSignUpOrLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Location = new System.Drawing.Point(174, 146);
            this.txtCustomerPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(78, 24);
            this.txtCustomerPassword.TabIndex = 3;
            this.txtCustomerPassword.TextChanged += new System.EventHandler(this.txtCustomerPassword_TextChanged);
            // 
            // lblMailAddress
            // 
            this.lblMailAddress.AutoSize = true;
            this.lblMailAddress.Location = new System.Drawing.Point(45, 117);
            this.lblMailAddress.Name = "lblMailAddress";
            this.lblMailAddress.Size = new System.Drawing.Size(108, 16);
            this.lblMailAddress.TabIndex = 6;
            this.lblMailAddress.Text = "Mail Adresiniz : \r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(47, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Şifre :";
            // 
            // gbxSignUpOrLogin
            // 
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerMailAddress);
            this.gbxSignUpOrLogin.Controls.Add(this.chkVisiblePassword);
            this.gbxSignUpOrLogin.Controls.Add(this.btnSignUp);
            this.gbxSignUpOrLogin.Controls.Add(this.lblBeCustomer);
            this.gbxSignUpOrLogin.Controls.Add(this.btnLogin);
            this.gbxSignUpOrLogin.Controls.Add(this.lblPassword);
            this.gbxSignUpOrLogin.Controls.Add(this.lblMailAddress);
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerPassword);
            this.gbxSignUpOrLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSignUpOrLogin.ForeColor = System.Drawing.Color.Honeydew;
            this.gbxSignUpOrLogin.Location = new System.Drawing.Point(14, 15);
            this.gbxSignUpOrLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSignUpOrLogin.Name = "gbxSignUpOrLogin";
            this.gbxSignUpOrLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSignUpOrLogin.Size = new System.Drawing.Size(412, 405);
            this.gbxSignUpOrLogin.TabIndex = 9;
            this.gbxSignUpOrLogin.TabStop = false;
            this.gbxSignUpOrLogin.Text = "Kullanıcı Giriş :";
            this.gbxSignUpOrLogin.Enter += new System.EventHandler(this.gbxSignUpOrLogin_Enter);
            // 
            // txtCustomerMailAddress
            // 
            this.txtCustomerMailAddress.Location = new System.Drawing.Point(174, 112);
            this.txtCustomerMailAddress.Name = "txtCustomerMailAddress";
            this.txtCustomerMailAddress.Size = new System.Drawing.Size(181, 24);
            this.txtCustomerMailAddress.TabIndex = 13;
            // 
            // chkVisiblePassword
            // 
            this.chkVisiblePassword.AutoSize = true;
            this.chkVisiblePassword.Location = new System.Drawing.Point(258, 148);
            this.chkVisiblePassword.Name = "chkVisiblePassword";
            this.chkVisiblePassword.Size = new System.Drawing.Size(112, 20);
            this.chkVisiblePassword.TabIndex = 12;
            this.chkVisiblePassword.Text = "Şifreyi göster";
            this.chkVisiblePassword.UseVisualStyleBackColor = true;
            this.chkVisiblePassword.CheckedChanged += new System.EventHandler(this.chkVisiblePassword_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Location = new System.Drawing.Point(283, 245);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(72, 27);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblBeCustomer
            // 
            this.lblBeCustomer.AutoSize = true;
            this.lblBeCustomer.Location = new System.Drawing.Point(132, 250);
            this.lblBeCustomer.Name = "lblBeCustomer";
            this.lblBeCustomer.Size = new System.Drawing.Size(157, 16);
            this.lblBeCustomer.TabIndex = 10;
            this.lblBeCustomer.Text = "Henüz üye değil misin ?";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(174, 192);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 38);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // SignUpOrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(440, 433);
            this.Controls.Add(this.gbxSignUpOrLogin);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUpOrLogin";
            this.Text = "SignUpOrLogin";
            this.Load += new System.EventHandler(this.SignUpOrLogin_Load);
            this.gbxSignUpOrLogin.ResumeLayout(false);
            this.gbxSignUpOrLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.Label lblMailAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbxSignUpOrLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblBeCustomer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkVisiblePassword;
        private System.Windows.Forms.TextBox txtCustomerMailAddress;
    }
}