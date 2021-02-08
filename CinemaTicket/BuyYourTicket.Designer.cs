
namespace CinemaTicket
{
    partial class BuyYourTicket
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxFilm = new System.Windows.Forms.GroupBox();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.MoviePicture = new System.Windows.Forms.PictureBox();
            this.cbxDate = new System.Windows.Forms.ComboBox();
            this.txtSeatNumber = new System.Windows.Forms.TextBox();
            this.lblMovieSession = new System.Windows.Forms.Label();
            this.lblMovieDate = new System.Windows.Forms.Label();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.btnChooseSeat = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChooseMovie = new System.Windows.Forms.Button();
            this.gbxCustomerData = new System.Windows.Forms.GroupBox();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPersonalId = new System.Windows.Forms.Label();
            this.lblCustomerSurName = new System.Windows.Forms.Label();
            this.gbxFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            this.gbxCustomerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFilm
            // 
            this.gbxFilm.Controls.Add(this.btnBuyTicket);
            this.gbxFilm.Controls.Add(this.MoviePicture);
            this.gbxFilm.Controls.Add(this.cbxDate);
            this.gbxFilm.Controls.Add(this.txtSeatNumber);
            this.gbxFilm.Controls.Add(this.lblMovieSession);
            this.gbxFilm.Controls.Add(this.lblMovieDate);
            this.gbxFilm.Controls.Add(this.lblSeatNumber);
            this.gbxFilm.Controls.Add(this.cbxSession);
            this.gbxFilm.Controls.Add(this.btnChooseSeat);
            this.gbxFilm.Controls.Add(this.textBox2);
            this.gbxFilm.Controls.Add(this.btnChooseMovie);
            this.gbxFilm.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFilm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxFilm.Location = new System.Drawing.Point(16, 15);
            this.gbxFilm.Name = "gbxFilm";
            this.gbxFilm.Size = new System.Drawing.Size(456, 356);
            this.gbxFilm.TabIndex = 49;
            this.gbxFilm.TabStop = false;
            this.gbxFilm.Text = "Film Bilgileri";
            this.gbxFilm.Enter += new System.EventHandler(this.gbxFilm_Enter);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuyTicket.Location = new System.Drawing.Point(11, 258);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(255, 40);
            this.btnBuyTicket.TabIndex = 59;
            this.btnBuyTicket.Text = "Bileti Al";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Visible = false;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // MoviePicture
            // 
            this.MoviePicture.BackColor = System.Drawing.Color.Silver;
            this.MoviePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviePicture.Location = new System.Drawing.Point(274, 77);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(172, 221);
            this.MoviePicture.TabIndex = 58;
            this.MoviePicture.TabStop = false;
            this.MoviePicture.Visible = false;
            // 
            // cbxDate
            // 
            this.cbxDate.FormattingEnabled = true;
            this.cbxDate.Location = new System.Drawing.Point(131, 77);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(135, 22);
            this.cbxDate.TabIndex = 57;
            this.cbxDate.Visible = false;
            this.cbxDate.SelectedIndexChanged += new System.EventHandler(this.cbxDate_SelectedIndexChanged);
            // 
            // txtSeatNumber
            // 
            this.txtSeatNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeatNumber.Location = new System.Drawing.Point(131, 212);
            this.txtSeatNumber.Multiline = true;
            this.txtSeatNumber.Name = "txtSeatNumber";
            this.txtSeatNumber.ReadOnly = true;
            this.txtSeatNumber.Size = new System.Drawing.Size(135, 25);
            this.txtSeatNumber.TabIndex = 56;
            this.txtSeatNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeatNumber.Visible = false;
            // 
            // lblMovieSession
            // 
            this.lblMovieSession.AutoSize = true;
            this.lblMovieSession.Location = new System.Drawing.Point(8, 113);
            this.lblMovieSession.Name = "lblMovieSession";
            this.lblMovieSession.Size = new System.Drawing.Size(43, 14);
            this.lblMovieSession.TabIndex = 55;
            this.lblMovieSession.Text = "Seans :";
            this.lblMovieSession.Visible = false;
            // 
            // lblMovieDate
            // 
            this.lblMovieDate.AutoSize = true;
            this.lblMovieDate.Location = new System.Drawing.Point(8, 80);
            this.lblMovieDate.Name = "lblMovieDate";
            this.lblMovieDate.Size = new System.Drawing.Size(39, 14);
            this.lblMovieDate.TabIndex = 54;
            this.lblMovieDate.Text = "Tarih :";
            this.lblMovieDate.Visible = false;
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Location = new System.Drawing.Point(8, 219);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(99, 14);
            this.lblSeatNumber.TabIndex = 6;
            this.lblSeatNumber.Text = "Seçilen Koltuklar :";
            this.lblSeatNumber.Visible = false;
            // 
            // cbxSession
            // 
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Location = new System.Drawing.Point(131, 110);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(135, 22);
            this.cbxSession.TabIndex = 53;
            this.cbxSession.Visible = false;
            this.cbxSession.SelectedIndexChanged += new System.EventHandler(this.cbxSession_SelectedIndexChanged);
            // 
            // btnChooseSeat
            // 
            this.btnChooseSeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseSeat.Location = new System.Drawing.Point(11, 148);
            this.btnChooseSeat.Name = "btnChooseSeat";
            this.btnChooseSeat.Size = new System.Drawing.Size(255, 45);
            this.btnChooseSeat.TabIndex = 4;
            this.btnChooseSeat.Text = "Koltuğu Seç";
            this.btnChooseSeat.UseVisualStyleBackColor = true;
            this.btnChooseSeat.Visible = false;
            this.btnChooseSeat.Click += new System.EventHandler(this.btnChooseSeat_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(274, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 49;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnChooseMovie
            // 
            this.btnChooseMovie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseMovie.Location = new System.Drawing.Point(11, 23);
            this.btnChooseMovie.Name = "btnChooseMovie";
            this.btnChooseMovie.Size = new System.Drawing.Size(435, 47);
            this.btnChooseMovie.TabIndex = 46;
            this.btnChooseMovie.Text = "Film Seçmek için tıklayın";
            this.btnChooseMovie.UseVisualStyleBackColor = true;
            this.btnChooseMovie.Click += new System.EventHandler(this.btnChooseMovie_Click);
            // 
            // gbxCustomerData
            // 
            this.gbxCustomerData.Controls.Add(this.lblKimlik);
            this.gbxCustomerData.Controls.Add(this.lblSoyad);
            this.gbxCustomerData.Controls.Add(this.lblAd);
            this.gbxCustomerData.Controls.Add(this.lblCustomerName);
            this.gbxCustomerData.Controls.Add(this.lblCustomerPersonalId);
            this.gbxCustomerData.Controls.Add(this.lblCustomerSurName);
            this.gbxCustomerData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxCustomerData.Location = new System.Drawing.Point(487, 15);
            this.gbxCustomerData.Name = "gbxCustomerData";
            this.gbxCustomerData.Size = new System.Drawing.Size(251, 132);
            this.gbxCustomerData.TabIndex = 48;
            this.gbxCustomerData.TabStop = false;
            this.gbxCustomerData.Text = "Kullanıcı Bilgileri";
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Location = new System.Drawing.Point(9, 91);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(73, 16);
            this.lblKimlik.TabIndex = 7;
            this.lblKimlik.Text = "Kimlik No:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(9, 59);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 16);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Soyisim";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(9, 27);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 16);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "İsim";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(105, 27);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerName.TabIndex = 0;
            // 
            // lblCustomerPersonalId
            // 
            this.lblCustomerPersonalId.AutoSize = true;
            this.lblCustomerPersonalId.Location = new System.Drawing.Point(105, 91);
            this.lblCustomerPersonalId.Name = "lblCustomerPersonalId";
            this.lblCustomerPersonalId.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerPersonalId.TabIndex = 2;
            // 
            // lblCustomerSurName
            // 
            this.lblCustomerSurName.AutoSize = true;
            this.lblCustomerSurName.Location = new System.Drawing.Point(105, 59);
            this.lblCustomerSurName.Name = "lblCustomerSurName";
            this.lblCustomerSurName.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerSurName.TabIndex = 1;
            // 
            // BuyYourTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(774, 395);
            this.Controls.Add(this.gbxFilm);
            this.Controls.Add(this.gbxCustomerData);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BuyYourTicket";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxFilm.ResumeLayout(false);
            this.gbxFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            this.gbxCustomerData.ResumeLayout(false);
            this.gbxCustomerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFilm;
        public System.Windows.Forms.TextBox txtSeatNumber;
        private System.Windows.Forms.Label lblMovieSession;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.Button btnChooseSeat;
        private System.Windows.Forms.Button btnChooseMovie;
        private System.Windows.Forms.GroupBox gbxCustomerData;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPersonalId;
        private System.Windows.Forms.Label lblCustomerSurName;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.PictureBox MoviePicture;
        public System.Windows.Forms.Label lblMovieDate;
        public System.Windows.Forms.ComboBox cbxDate;
        public System.Windows.Forms.Label lblSeatNumber;
        public System.Windows.Forms.Button btnBuyTicket;
    }
}

