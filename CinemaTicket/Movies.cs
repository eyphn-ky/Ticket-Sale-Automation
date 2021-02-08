using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicket
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }
        public  BuyYourTicket buyYourTicket;
       
        private void Movies_Load(object sender, EventArgs e)
        {
            
            MovieManager movieManager = new MovieManager(new EfMovieDal());
            List<Movie> movies= movieManager.GetAll();
            int i = movies.Count;
            int Left =20;
            int Top = 40;
            
            for (int k=1;k<=i;k++)
            {
                PictureBox pictureBox = new PictureBox();
                
                pictureBox.Width = 130;
                pictureBox.Height = 180;
                pictureBox.ImageLocation = ("images\\"+movies[k-1].Image.ToString());
                pictureBox.Tag=(movies[k-1].Id);
                pictureBox.Name = (movies[k - 1].Name);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Left = Left;
                pictureBox.Top = Top;
                pictureBox.Click += pictureBox_Click;              
                this.Controls.Add(pictureBox);
                Left += 150;
              

            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            buyYourTicket.MovieId =int.Parse(pictureBox.Tag.ToString());     
            buyYourTicket.textBox2.Text = pictureBox.Name.ToString();
            buyYourTicket.MoviePicture.BackgroundImage = pictureBox.Image;
            AfterSelectMovie();
            this.Close();
        }
        public void AfterSelectMovie()
        {
            buyYourTicket.MoviePicture.Visible = true;
            buyYourTicket.textBox2.Visible = true;
            buyYourTicket.lblMovieDate.Visible = true;
            buyYourTicket.cbxDate.Visible = true;
        }
     
    }
}
