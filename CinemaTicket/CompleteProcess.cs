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
using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace CinemaTicket
{
    public partial class CompleteProcess : Form
    {
        public CompleteProcess()
        {
            InitializeComponent();
        }
        public Reservation reservation = new Reservation();
        public BuyYourTicket BuyYourTicket = new BuyYourTicket();
        public string MovieName;
        public List<int> seats;
        public string CustomerName;
        public string CustomerLastName;
        public string Session;
        IReservationService reservationManager = new ReservationManager(new EfReservationDal());

        private void CompleteProcess_Load(object sender, EventArgs e)
        {

            txtMovie.Text = MovieName.ToString();
            txtDate.Text = reservation.Date;
            txtCustomerNameAndLastName.Text = CustomerName + " " + CustomerLastName;
            txtSaloon.Text = reservation.SaloonId.ToString();
            for(int i=0;i<seats.Count;i++)
            {
                txtSeat.Text += seats[i]+" ";
            }
            txtSession.Text = Session;
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            for(int i =0; i<seats.Count;i++)
            {
                reservation.SeatNumber = seats[i];
                reservationManager.Add(reservation);
               
            }
            
            MessageBox.Show("İşlem Başarılı","Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
