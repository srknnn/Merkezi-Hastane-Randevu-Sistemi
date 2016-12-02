using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;
using System.Globalization;


namespace LoginForm
{
    public partial class RegisterForm : Form
    {

        PatientBLL _patientBLL;
        Patient _patient;
        UserLogin _user;
        UserLoginBLL _userBLL;
        bool IsSave = true;
        List<long> _identity;
        List<string> _mail;


        public RegisterForm()
        {
            InitializeComponent();
            _patientBLL = new PatientBLL();
            _userBLL = new UserLoginBLL();
            _user = new UserLogin();
            _identity = new List<long>();
            _mail = new List<string>();
            DateControl();

        }

        public RegisterForm(int id)
        {
            _patientBLL = new PatientBLL();
            _userBLL = new UserLoginBLL();
            _user = _userBLL.GetUserLogin(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult sure = new DialogResult();
            sure = MessageBox.Show("Kayıt İşleminizi Onaylıyor musunuz?","",MessageBoxButtons.YesNo);
           
            if (txtPassword.Text == txtPasswordAgain.Text && txtPassword.TextLength >= 6 && txtPassword.TextLength <= 15)
            {
                if (txtAnswer.Text != "" && cmbSecurityQuest.SelectedIndex > -1)
                {

                    _patient = new Patient();

                    _patient.IdentityNumber = long.Parse(txtIıdentityNO.Text);
                    _patient.FirstName = txtFirstName.Text;
                    _patient.LastName = txtLastName.Text;
                    _patient.gender = Convert.ToString(cmbGender.SelectedItem);
                    _patient.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Value.ToShortDateString());
                    _patient.PlaceOfBirth = txtDateOfPlace.Text;
                    _patient.MotherName = txtMotherName.Text;
                    _patient.FatherName = txtFatherName.Text;
                    _patient.CellPhone = mtxtCellPhone.Text;
                    _patient.HomePhone = mtxtHomePhone.Text;
                    _patient.EMail = txtEmail.Text;



                    _patient.Password = txtPassword.Text;
                    _patient.SecurityQuestion = Convert.ToString(cmbSecurityQuest.SelectedItem);
                    _patient.Answer = txtAnswer.Text;
                    bool result;

                    if (IsSave)
                    {
                        if (sure == DialogResult.Yes)
                        {
                            result = _patientBLL.Insert(_patient);
                            MessageBox.Show("Kayıt İşleminiz Gerçekleşmiştir Giriş Ekranına Yönlendiriliyorsunuz..");

                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kayıt İşlemi Başarısız Olmuştur!");
                    }


                }
                else
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Parolanızı 6 İle 15 Karakter Uzunluğunda Giriniz!");
            }
}


        private void btnNextPersonel_Click(object sender, EventArgs e)
        {
            foreach (UserLogin item in _userBLL.GetUserALL())
            {
                _identity.Add(item.IdentityNumber);

            }

            if (_identity.Contains(long.Parse(txtIıdentityNO.Text)))
            {

                MessageBox.Show(" Sistemde zaten kaydınız vardır! Eğer parolanızı hatırlamıyorsanız lütfen parola hatırlatma ekranını kullanınız!");
                grpbxCommi.Enabled = false;
                grpbxPersonDetail1.Enabled = true;

            }
            else
            {
                if (txtIıdentityNO.TextLength == 11)
                {

                    if ((txtFirstName.Text != "" && txtFirstName.TextLength >= 2) && (txtLastName.Text != "" && txtLastName.TextLength >= 2) && cmbGender.SelectedIndex > -1)
                    {
                        grpbxPersonDetail1.Enabled = false;
                        grpbxCommi.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz!");

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen T.C. Numaranız'ı Kontrol Ediniz!");
                }
            }
        }
        
   
        private void btnBackPersonel_Click(object sender, EventArgs e)
        {
            grpbxCommi.Enabled = false;
            grpbxPersonDetail1.Enabled = true;
        }

        private void btnNextCommi_Click(object sender, EventArgs e)
        {

            foreach (UserLogin item in _userBLL.GetUserALL())
            {
                

                _mail.Add(item.Email);

            }
            if (_mail.Contains(txtEmail.Text))
            {
                MessageBox.Show("Bu Mail ile daha önceden Kayıt olunmuştur. Lütfen Başka Bir Mail Giriniz! ");
                grpbxCommi.Enabled = true;
                grpbxSecurity.Enabled = false;
            }
            else if (mtxtCellPhone.TextLength == 14 && mtxtHomePhone.TextLength == 14 && mtxtCellPhone.MaskFull && mtxtHomePhone.MaskFull)
            {
                if (txtEmail.Text == txtEmailAgain.Text && txtEmail.Text != "")
                {
                    grpbxCommi.Enabled = false;
                    grpbxSecurity.Enabled = true;

                    try
                    {
                        var mail = new MailAddress(txtEmail.Text);

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lütfen Maili Doğru Formatta Giriniz!");
                        grpbxCommi.Enabled = true;
                        grpbxSecurity.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Mailleriniz Aynı Olduğunu Kontrol Ediniz!");
                }
            }
            else
                MessageBox.Show("Lütfen Telefon Bilgilerinizi Eksik Girdiniz!");
        }

        private void btnBackCommi_Click(object sender, EventArgs e)
        {
            grpbxSecurity.Enabled = false;
            grpbxCommi.Enabled = true;
        }

        private void DateControl()
        {
            dtpDateOfBirth.MaxDate = DateTime.Today;
        }

        private void txtIıdentityNO_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
&& !char.IsSeparator(e.KeyChar);
           


        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
&& !char.IsSeparator(e.KeyChar);
        }

        private void txtDateOfPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
 && !char.IsSeparator(e.KeyChar);
        }

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
 && !char.IsSeparator(e.KeyChar);
        }

        private void txtMotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
&& !char.IsSeparator(e.KeyChar);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
