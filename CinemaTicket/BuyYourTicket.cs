using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class BuyYourTicket : Form
    {
        public BuyYourTicket(Customer customer)
        {
            InitializeComponent();
            Customer _customer = customer;
         
        }
        string day;/* Filme göre gelen tarihlerden seçilen tarih */
        List<Date> days;
        DateManager dateManager;
        List<SessionDetailDto> sessions;
        int SessionId;
        public int MovieId;
        public List<int> selectedSeats;
        public Customer _customer;

        public void Form1_Load(object sender, EventArgs e)
        {
            dateManager = new DateManager(new EfDateDal());
            lblCustomerName.Text = _customer.Name;
            lblCustomerPersonalId.Text = _customer.NationalIdentity;
            lblCustomerSurName.Text = _customer.LastName;
        }
      
        private void btnChooseMovie_Click(object sender, EventArgs e)
        {
            try { 
            Movies movies = new Movies();
            movies.buyYourTicket = this;
            movies.Show();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message,"HATA!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cbxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            day = cbxDate.SelectedItem.ToString();
            cbxSession.Items.Clear();
            cbxSession.Text = "";
            sessions = dateManager.GetSessionDetails(MovieId, day).ToList();
            for (int i = 1; i <= sessions.Count; i++)
            {
                cbxSession.Items.Add(sessions[i - 1].SessionName.ToString());
            }
            AfterSelectDate();
            

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

            cbxDate.Items.Clear();
            cbxDate.Text = "";

            days = dateManager.GetDateByMovieId(MovieId).ToList();
            for (int i = 1; i <= days.Count; i++)
            {
                cbxDate.Items.Add(days[i - 1].Day.ToString());
            }
            ResetAllVisibles();
        }
        public void ResetAllVisibles()
        {
            cbxSession.Visible = false;
            lblMovieSession.Visible = false;
            btnChooseSeat.Visible = false;
            txtSeatNumber.Visible = false;
            lblSeatNumber.Visible = false;
            btnBuyTicket.Visible = false;
            cbxSession.Text = "";
            txtSeatNumber.Text = "";
        }
        private void cbxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < sessions.Count; i++)
            {
                if (sessions[i].SessionName == cbxSession.SelectedItem.ToString())
                {
                    SessionId = sessions[i].SessionId;
                }

            }
            AfterSelectSession();


        }
        public void AfterSelectDate()
        {
            cbxSession.Visible = true;
            lblMovieSession.Visible = true;
            txtSeatNumber.Text = "";
        }

        public void AfterSelectSession()
        {
            btnChooseSeat.Visible = true;
        }
      

        private void btnChooseSeat_Click(object sender, EventArgs e)
        {
            ChooseYourSeat chooseYourTicket = new ChooseYourSeat();
            chooseYourTicket.buyYourTicket = this;
            chooseYourTicket.MovieId = MovieId;
            chooseYourTicket.SessionId = SessionId;
            chooseYourTicket.Date = day;
            chooseYourTicket.Show();
        }

        private void gbxFilm_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
          
        }
    }
}
