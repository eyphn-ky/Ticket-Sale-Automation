
namespace CinemaTicket
{
    partial class ChooseYourSeat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSeciliKoltukAd = new System.Windows.Forms.Label();
            this.txtSelectedSeat = new System.Windows.Forms.Label();
            this.btnApproveSeat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 459);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(31, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 328);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSeciliKoltukAd);
            this.groupBox2.Controls.Add(this.txtSelectedSeat);
            this.groupBox2.Controls.Add(this.btnApproveSeat);
            this.groupBox2.Location = new System.Drawing.Point(522, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 237);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // lblSeciliKoltukAd
            // 
            this.lblSeciliKoltukAd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSeciliKoltukAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeciliKoltukAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeciliKoltukAd.Location = new System.Drawing.Point(6, 27);
            this.lblSeciliKoltukAd.Name = "lblSeciliKoltukAd";
            this.lblSeciliKoltukAd.Size = new System.Drawing.Size(132, 30);
            this.lblSeciliKoltukAd.TabIndex = 42;
            this.lblSeciliKoltukAd.Text = "Seçilen Koltuk";
            this.lblSeciliKoltukAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSelectedSeat
            // 
            this.txtSelectedSeat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSelectedSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedSeat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedSeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSelectedSeat.Location = new System.Drawing.Point(6, 90);
            this.txtSelectedSeat.Name = "txtSelectedSeat";
            this.txtSelectedSeat.Size = new System.Drawing.Size(132, 55);
            this.txtSelectedSeat.TabIndex = 41;
            this.txtSelectedSeat.Tag = "7";
            this.txtSelectedSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApproveSeat
            // 
            this.btnApproveSeat.Location = new System.Drawing.Point(6, 172);
            this.btnApproveSeat.Name = "btnApproveSeat";
            this.btnApproveSeat.Size = new System.Drawing.Size(132, 34);
            this.btnApproveSeat.TabIndex = 43;
            this.btnApproveSeat.Text = "KOLTUĞU SEÇ";
            this.btnApproveSeat.UseVisualStyleBackColor = true;
            this.btnApproveSeat.Click += new System.EventHandler(this.btnConfirmSeat_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERDE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseYourSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ChooseYourSeat";
            this.Text = "ChooseYourTicket";
            this.Load += new System.EventHandler(this.ChooseYourTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSeciliKoltukAd;
        public System.Windows.Forms.Label txtSelectedSeat;
        private System.Windows.Forms.Button btnApproveSeat;
        private System.Windows.Forms.Label label1;
    }
}