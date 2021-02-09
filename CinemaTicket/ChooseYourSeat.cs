using BusinessLogic.Abstract;
using BusinessLogic.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace CinemaTicket
{
    public partial class ChooseYourSeat : Form
    {
        public BuyYourTicket buyYourTicket;
        public ChooseYourSeat()
        {
            InitializeComponent();
        }
        public int MovieId;
        public int SaloonId = 1;
        public int SessionId;
        public string Date;

        private void ChooseYourTicket_Load(object sender, EventArgs e)
        {
            SeatManager seatManager = new SeatManager(new EfSeatDal());
            ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
            int Left = 8;
            int Top = 30;
            List<Seat> seats = seatManager.GetSeatBySaloonId(SaloonId);            
            List<Reservation> reservations = reservationManager.GetReservationsEmptyOrSold(MovieId, SessionId, 1, Date);
            int j = seats.Count;
            int a = 0;

            for (int k = 1; k <= j; k++)
            {
                Button button = new Button();
                button.Name = "btn" + k;
                button.Text = k.ToString();
                button.ForeColor = Color.White;
                button.Width = 40;
                button.Height = 40;
                button.Left = Left;
                button.Top = Top;
                button.Click += BtnChooseSeat_Click;
                if (reservations.Count != 0 && reservations[a].SeatNumber == k)
                {
                    button.BackColor = Color.Red;
                    if ((reservations.Count - 1) != a)
                    {
                        a++;
                    }
                }
                else
                {
                    button.BackColor = Color.Blue;
                }
                groupBox4.Controls.Add(button);
                Left += 45;
                if (k % 10 == 0)
                {
                    Top += 60;
                    Left = 8;
                }
            }
        }
        public List<int> selectedSeats = new List<int>();
        private void BtnChooseSeat_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtSelectedSeat.Text = "";
            if (button.BackColor != Color.Red )
            {
                if (button.BackColor == Color.Blue)
                {
                    selectedSeats.Add(int.Parse(button.Text));
                    button.BackColor = Color.Green;
                    for(int i=1;i<=selectedSeats.Count;i++)
                    {

                        if (selectedSeats.Count == 1)
                        {
                            txtSelectedSeat.Text = selectedSeats[i-1].ToString();
                        }
                        else
                        {
                            txtSelectedSeat.Text += selectedSeats[i - 1].ToString()+" ";
                        }
                    }
                }
                else if (button.BackColor==Color.Green)
                {
                    txtSelectedSeat.Text = "";
                    selectedSeats.Remove(int.Parse(button.Text));
                    for (int i = 1; i <= selectedSeats.Count; i++)
                    {
                        if (selectedSeats.Count == 1)
                        {

                            txtSelectedSeat.Text = selectedSeats[i-1].ToString();
                        }
                        else
                        {
                            txtSelectedSeat.Text += selectedSeats[i - 1].ToString()+" ";
                        }
                    }
                    button.BackColor = Color.Blue;
                 
                }
            }
            selectedSeats.Sort();
        }
        public void AfterClickChooseSeatButton()
        {
            buyYourTicket.lblSeatNumber.Visible = true;
            buyYourTicket.txtSeatNumber.Visible = true;
            buyYourTicket.btnBuyTicket.Visible = true;
           
        
        }
        private void btnConfirmSeat_Click(object sender, EventArgs e)
        {
            buyYourTicket.selectedSeats = selectedSeats;
            buyYourTicket.txtSeatNumber.Text = txtSelectedSeat.Text;
            buyYourTicket.SaloonId = SaloonId;
            AfterClickChooseSeatButton();
            this.Close();
        }
    }
}
