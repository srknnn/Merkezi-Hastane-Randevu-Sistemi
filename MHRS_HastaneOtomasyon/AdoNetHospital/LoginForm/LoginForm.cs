using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;
using System.Net.Mail;
using System.Net;

namespace LoginForm
{
    public partial class LoginForm : Form
    {

        Random _rand;
        UserLoginBLL _userBLL;
        UserLogin _user;
        List<long> _identity;
        List<string> _password;
        int _UserID;
        AppointmentSave _apointmentForm = new AppointmentSave();
        AppointmentStatusListForm _appointStatusListForm = new AppointmentStatusListForm();


        public LoginForm()
        {
            
            InitializeComponent();
            _rand = new Random();
            _userBLL = new UserLoginBLL();
            _user = new UserLogin();
            _identity = new List<long>();
            _password = new List<string>();
          
        }

        int _randomNumber = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            foreach (UserLogin item in _userBLL.GetUserALL())
            {
                if (long.Parse(txtBxIdentitiyNumber.Text.ToString())==item.IdentityNumber)
                {
                    _UserID = item.UserID;
                    _identity.Add(item.IdentityNumber);
                    _password.Add(item.Password);
                }
            
            }


            _apointmentForm._userID = _UserID;
            _appointStatusListForm._userID = _UserID;
            
            
            if (_identity.Contains((long.Parse(txtBxIdentitiyNumber.Text))) && (_password.Contains(txtBxPassword.Text)))
            {

                if(txtBxIdentitiyNumber.Text == "" && txtBxPassword.Text == "")
                {
                    MessageBox.Show("Lütfen gerekli alanları boş bırakmayınız!");
                }


                if (lblSecurityAnswer.Text == txtBxSecurityNumber.Text)
                {
                    _apointmentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Güvenlik Kodunu Kontrol Ediniz!");
                    txtBxSecurityNumber.Text = "";
                    _rand = new Random();
                    _randomNumber = _rand.Next(10000, 99999);
                    lblSecurityAnswer.Text = _randomNumber.ToString();
                    
                    
                }

            }
            else
            {
                MessageBox.Show("TC Kimlik Numarası veya Şifre Yanlış! Lütfen Bilgilerinizi Kontrol Ediniz.");
                txtBxIdentitiyNumber.Text = "";
                txtBxPassword.Text = "";
                txtBxSecurityNumber.Text = "";
                _rand = new Random();
                _randomNumber = _rand.Next(10000, 99999);
                lblSecurityAnswer.Text = _randomNumber.ToString();
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();

            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _randomNumber = _rand.Next(10000, 99999);
            lblSecurityAnswer.Text = _randomNumber.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _randomNumber = _rand.Next(10000, 99999);
            lblSecurityAnswer.Text = _randomNumber.ToString();
        }


        private void IdentitiyClear()
        {
            txtBxIdentitiyNumber.Text = "";
        }

        private void PasswordClear()
        {
            txtBxPassword.Text = "";
            txtBxPassword.PasswordChar = '*';
        }

        private void txtBxIdentitiyNumber_Click(object sender, EventArgs e)
        {
            IdentitiyClear();
        }

        private void txtBxPassword_Click(object sender, EventArgs e)
        {
            PasswordClear();
            

        }

        private void SecurityClear()
        {
            txtBxSecurityNumber.Text = "";
        }

        private void txtBxSecurityNumber_Click(object sender, EventArgs e)
        {
            SecurityClear();
        }


        private void btnNotRemember_Click_1(object sender, EventArgs e)
        {
            PasswordRememberForm passwordRemember = new PasswordRememberForm();
            passwordRemember.Show();
            this.Hide();
        }

        private void txtBxIdentitiyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }
    }
}
