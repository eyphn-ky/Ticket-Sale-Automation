using BusinessLogic.Concrete;
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
    public partial class SignUpOrLogin : Form
    {
        public SignUpOrLogin()
        {
            InitializeComponent();
        }
        CustomerManager customerManager;
        Customer customerRegister;
        Customer customer;
        private void SignUpOrLogin_Load(object sender, EventArgs e)
        {
            customerManager= new CustomerManager(new EfCustomerDal());
            customerRegister = new Customer();
            customer = new Customer();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            customerRegister.Id = int.Parse(txtCustomerId.Text);
            customerRegister.Name = txtCustomerName.Text;
            customerRegister.LastName = txtCustomerLastName.Text;
            customerRegister.Password = txtCustomerPassword.Text;
          
            if(customerManager.IsRegistered(customerRegister)==false)
            {
                MessageBox.Show("Bilgileriniz Kontrol Ediniz !", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                customer = customerManager.Get(p => p.Id == int.Parse(txtCustomerId.Text));
                BuyYourTicket buyYourTicket = new BuyYourTicket(customer);               
                this.Close();
                buyYourTicket.Show();
            }


        }
    }
}
