using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using BusinessLayer;
using Entities;



namespace LoginForm
{
    public partial class PasswordRememberForm : Form
    {
        public PasswordRememberForm()
        {
            InitializeComponent();
            _userBLL = new UserLoginBLL();
            _user = new UserLogin();

        }

        string _mail;
        long _identity;
        UserLoginBLL _userBLL;
        UserLogin _user;
        string _password;


        public void MailGonder()
        {
            foreach (UserLogin item in _userBLL.GetUserALL())
            {
                _mail = item.Email;
                _identity = item.IdentityNumber;
                _password = item.Password;
                
            }

            if((long.Parse(txtIdentity.Text) == _identity) && (txtBxEMail.Text == _mail))
            {
                if (txtIdentity.Text == "" && txtBxEMail.Text == "")
                {
                    MessageBox.Show("Lütfen gerekli alanları boş bırakmayınız");
                }
            }
            
        try
            {
                
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(txtBxEMail.Text);
                mesaj.From = new MailAddress("asdas@gmail.com");
                mesaj.Subject = "MHRS Şifremi Unuttum";
                mesaj.Body = string.Format("MHRS sistemine ait Kullanıcı şifreniz :{0}",_password);
                NetworkCredential guvenlik = new NetworkCredential("yiwit.tas@gmail.com","yiwit4757691");
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(mesaj);
                MessageBox.Show("Şifreniz Başarıyla E-Mail Adresinize Gönderilmiştir.", "Şifremi Unuttum");
            }
            catch
            {
                MessageBox.Show("Mail Gönderme Başarısız.", "Mail Gönderme");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailGonder();

        }

       

        private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxEMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}