
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbxSignUpOrLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblBeCustomer = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.gbxSignUpOrLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(239, 114);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(116, 24);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(239, 154);
            this.txtCustomerLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(116, 24);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Location = new System.Drawing.Point(239, 193);
            this.txtCustomerPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(116, 24);
            this.txtCustomerPassword.TabIndex = 3;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(239, 75);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(116, 24);
            this.txtCustomerId.TabIndex = 4;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(45, 79);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(119, 16);
            this.lblCustomerId.TabIndex = 5;
            this.lblCustomerId.Text = "Kullanıcı numarası :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(45, 118);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 16);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "İsim :";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(45, 157);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(59, 16);
            this.lblCustomerLastName.TabIndex = 7;
            this.lblCustomerLastName.Text = "Soyisim :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(45, 197);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(43, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Şifre :";
            // 
            // gbxSignUpOrLogin
            // 
            this.gbxSignUpOrLogin.Controls.Add(this.btnSignUp);
            this.gbxSignUpOrLogin.Controls.Add(this.lblBeCustomer);
            this.gbxSignUpOrLogin.Controls.Add(this.btnLogin);
            this.gbxSignUpOrLogin.Controls.Add(this.lblCustomerId);
            this.gbxSignUpOrLogin.Controls.Add(this.lblPassword);
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerName);
            this.gbxSignUpOrLogin.Controls.Add(this.lblCustomerLastName);
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerLastName);
            this.gbxSignUpOrLogin.Controls.Add(this.lblCustomerName);
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerPassword);
            this.gbxSignUpOrLogin.Controls.Add(this.txtCustomerId);
            this.gbxSignUpOrLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSignUpOrLogin.Location = new System.Drawing.Point(14, 15);
            this.gbxSignUpOrLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSignUpOrLogin.Name = "gbxSignUpOrLogin";
            this.gbxSignUpOrLogin.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSignUpOrLogin.Size = new System.Drawing.Size(412, 405);
            this.gbxSignUpOrLogin.TabIndex = 9;
            this.gbxSignUpOrLogin.TabStop = false;
            this.gbxSignUpOrLogin.Text = "Kullanıcı Giriş :";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(48, 239);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(308, 46);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblBeCustomer
            // 
            this.lblBeCustomer.AutoSize = true;
            this.lblBeCustomer.Location = new System.Drawing.Point(45, 309);
            this.lblBeCustomer.Name = "lblBeCustomer";
            this.lblBeCustomer.Size = new System.Drawing.Size(145, 16);
            this.lblBeCustomer.TabIndex = 10;
            this.lblBeCustomer.Text = "Henüz üye değil misin ?";
            // 
            // btnSignUp
            // 
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUp.Location = new System.Drawing.Point(206, 294);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 46);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
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

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbxSignUpOrLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblBeCustomer;
        private System.Windows.Forms.Button btnLogin;
    }
}