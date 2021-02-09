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
        public SignUpOrLogin sign;

        private void SignUpOrLogin_Load(object sender, EventArgs e)
        {
            customerManager = new CustomerManager(new EfCustomerDal());
            customerRegister = new Customer();
            customer = new Customer();
            txtCustomerPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
             
                customerRegister.Mail =txtCustomerMailAddress.Text;
                customerRegister.Password = txtCustomerPassword.Text;

                if (customerManager.IsRegistered(customerRegister) == false)
                {
                    MessageBox.Show("Bilgileriniz Kontrol Ediniz !", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string CustomerMail = txtCustomerMailAddress.Text;
                    customer = customerManager.Get(p => p.Mail == CustomerMail);
                    BuyYourTicket buyYourTicket = new BuyYourTicket();
                    buyYourTicket.customer = customer;                 
                    buyYourTicket.Show();
                    this.Visible = false;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Uyarı");
            }

       
        }

        private void txtCustomerPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gbxSignUpOrLogin_Enter(object sender, EventArgs e)
        {

        }

        private void chkVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (chkVisiblePassword.Checked)
            {
                //karakteri göster.
                txtCustomerPassword.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtCustomerPassword.PasswordChar = '*'; // "*" yerine ne eklerseniz şifreyi gizlerken ne yazmışsanız o şekilde gizler .
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Visible = false;
        }
    }
}
