
namespace CinemaTicket
{
    partial class CompleteProcess
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
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaloon = new System.Windows.Forms.Label();
            this.lblCustomerNameAndLastName = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.txtSaloon = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtCustomerNameAndLastName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(92, 73);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(45, 16);
            this.lblMovie.TabIndex = 0;
            this.lblMovie.Text = "Film :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(92, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tarih :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnComplete);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtCustomerNameAndLastName);
            this.groupBox1.Controls.Add(this.txtSeat);
            this.groupBox1.Controls.Add(this.txtSession);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtSaloon);
            this.groupBox1.Controls.Add(this.txtMovie);
            this.groupBox1.Controls.Add(this.lblCustomerNameAndLastName);
            this.groupBox1.Controls.Add(this.lblSaloon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSeans);
            this.groupBox1.Controls.Add(this.lblMovie);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemi Onayla";
            // 
            // lblSeans
            // 
            this.lblSeans.AutoSize = true;
            this.lblSeans.Location = new System.Drawing.Point(92, 157);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(60, 16);
            this.lblSeans.TabIndex = 2;
            this.lblSeans.Text = "Seans :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Koltuk :";
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(92, 101);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(48, 16);
            this.lblSaloon.TabIndex = 4;
            this.lblSaloon.Text = "Salon";
            // 
            // lblCustomerNameAndLastName
            // 
            this.lblCustomerNameAndLastName.AutoSize = true;
            this.lblCustomerNameAndLastName.Location = new System.Drawing.Point(92, 213);
            this.lblCustomerNameAndLastName.Name = "lblCustomerNameAndLastName";
            this.lblCustomerNameAndLastName.Size = new System.Drawing.Size(66, 16);
            this.lblCustomerNameAndLastName.TabIndex = 5;
            this.lblCustomerNameAndLastName.Text = "Müşteri :";
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(215, 70);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.ReadOnly = true;
            this.txtMovie.Size = new System.Drawing.Size(119, 22);
            this.txtMovie.TabIndex = 6;
            // 
            // txtSaloon
            // 
            this.txtSaloon.Location = new System.Drawing.Point(215, 98);
            this.txtSaloon.Name = "txtSaloon";
            this.txtSaloon.ReadOnly = true;
            this.txtSaloon.Size = new System.Drawing.Size(119, 22);
            this.txtSaloon.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(215, 126);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(119, 22);
            this.txtDate.TabIndex = 8;
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(215, 154);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(119, 22);
            this.txtSession.TabIndex = 9;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(215, 182);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.ReadOnly = true;
            this.txtSeat.Size = new System.Drawing.Size(119, 22);
            this.txtSeat.TabIndex = 10;
            // 
            // txtCustomerNameAndLastName
            // 
            this.txtCustomerNameAndLastName.Location = new System.Drawing.Point(215, 210);
            this.txtCustomerNameAndLastName.Name = "txtCustomerNameAndLastName";
            this.txtCustomerNameAndLastName.ReadOnly = true;
            this.txtCustomerNameAndLastName.Size = new System.Drawing.Size(119, 22);
            this.txtCustomerNameAndLastName.TabIndex = 11;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(92, 241);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Ücret :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(215, 238);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(119, 34);
            this.txtPrice.TabIndex = 14;
            // 
            // btnComplete
            // 
            this.btnComplete.ForeColor = System.Drawing.Color.Black;
            this.btnComplete.Location = new System.Drawing.Point(259, 278);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 45);
            this.btnComplete.TabIndex = 15;
            this.btnComplete.Text = "Onayla";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(178, 278);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 45);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Geri Dön";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(95, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CompleteProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "CompleteProcess";
            this.Text = "CompleteProcess";
            this.Load += new System.EventHandler(this.CompleteProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCustomerNameAndLastName;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCustomerNameAndLastName;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtSaloon;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnExit;
    }
}