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
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class AppointmentSave : Form
    {
        HospitalDetailBLL hostbll = new HospitalDetailBLL();
        SqlCommand command;
        List<Button> buttonList;
        AppointmentBLL apoBLL;
       public int _userID;
     
      

      
        public AppointmentSave()
        {
            InitializeComponent();
            command = new SqlCommand();
            hospitalBLL = new HospitalDetailBLL();
            hospitalDetails = new HospitalDetail();
            buttonList = new List<Button>();
            apoBLL = new AppointmentBLL();
         
    
        }

        HospitalDetailBLL hospitalBLL;
        HospitalDetail hospitalDetails;


        List<HospitalDetail> hostlist = new List<HospitalDetail>();
        private void DateControl()
        {

            dTPAppointmentDate.MinDate = DateTime.Today;
            dTPAppointmentDate.MaxDate = DateTime.Today.AddDays(15);

        }

        public void TimeFill()
        {

           
            groupAppointment.Controls.Clear();
            HospitalDetail clinic = (HospitalDetail)cBxSelectClinic.SelectedValue;
            HospitalDetail doctor = (HospitalDetail)cBxSelectDoctor.SelectedValue;
            buttonList = new List<Button>();
             


            
            int timeRange = clinic.ClinicRangeTime;
            string startTime = clinic.ClinicStartTime.ToShortTimeString();
            string endTime = clinic.ClinicEndTime.ToShortTimeString();
            bool flag = true;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Width = 50;
                    button.Height = 25;
                    button.Top = (i + 1) * 25;
                    button.Left = (j + 1) * 55;
                    button.BackColor = Color.Green;
                    button.Text = Convert.ToDateTime(startTime).ToShortTimeString();
                    startTime = Convert.ToDateTime(startTime).AddMinutes(timeRange).ToString();
                    groupAppointment.Controls.Add(button);
                    buttonList.Add(button);
                    button.Click += Button_Click;
                   
                }

            }
            startTime = "13:00";

            for (int k = 4; k < 9; k++)
            {
                for (int l = 0; l < 3; l++)
                {


                    Button button1 = new Button();
                    button1.Width = 50;
                    button1.Height = 25;
                    button1.Top = (k + 1) * 25;
                    button1.Left = (l + 1) * 55;
                    button1.BackColor = Color.Green;
                    button1.Text = Convert.ToDateTime(startTime).ToShortTimeString();
                    startTime = Convert.ToDateTime(startTime).AddMinutes(timeRange).ToString();
                    groupAppointment.Controls.Add(button1);
                    buttonList.Add(button1);

                    button1.Click += Button_Click;
                    
                    if (button1.Text == "17:00")
                    {
                        flag = false;
                        break;
                    }

                }


                if (flag == false)
                {
                    break;
                }
            }


            List<String> listReserve = new List<String>();
            //listReserve.AddRange(apoBLL.GetDoctorTimeAll(dTPAppointmentDate.Value.Date, doctor.DoctorID));

            listReserve.AddRange(apoBLL.GetDoctorTimeAll(doctor.DoctorID, dTPAppointmentDate.Value));


            for (int i = 0; i < buttonList.Count; i++)
            {
                for (int j = 0; j < listReserve.Count; j++)
                {
                    if (buttonList[i].Text == Convert.ToDateTime(listReserve[j]).ToShortTimeString())
                    {
                        buttonList[i].Enabled = false;
                        buttonList[i].BackColor = Color.Transparent;
                    }
                }


            }

        }


        private void Button_Click(object sender, EventArgs e)
        {
            
            Button selectedbuton = (Button)sender;
            HospitalDetail doctor = (HospitalDetail)cBxSelectDoctor.SelectedValue;
            Appointment apointment = new Appointment();

              DialogResult = MessageBox.Show("Kaydı onaylıyor musunuz?", "Randevu", MessageBoxButtons.YesNo);
              if (DialogResult.Yes == DialogResult)
              {
                  apointment.PatientID = _userID;
                  apointment.DoctorID = doctor.DoctorID;
                  apointment.AppointmenDate = dTPAppointmentDate.Value.Date;
                  apointment.AppointTime = DateTime.Parse(selectedbuton.Text.ToString());

                  bool save = apoBLL.Insert(apointment);
                  if (save)
                  {
                      MessageBox.Show("Belirtilen Tarih Ve Klinikte Randevunuz Başarıyla Alınmıştır.");
                    TimeFill();
                    
                  }
                  else 
                  {
                      MessageBox.Show("Randevunuz alınamadı!");
                  }
              }
           
        }

        private void AppointmentSave_Load(object sender, EventArgs e)
        {
            DateControl();
            HospitalDetail hostd = new HospitalDetail();
            cBxSelectCity.DataSource = hostbll.GetCityAll();

        }
        private void ListAdd()
        {
            lstVAppointmentList.Items.Clear();
            lstVAppointmentList.BackColor = Color.White;

            HospitalDetail hostdetail = new HospitalDetail();
            hostdetail.CityName = cBxSelectCity.SelectedValue.ToString();
            hostdetail.TownName = cBxSelectTown.SelectedValue.ToString();
            hostdetail.HospitalName = cBxSelectHospital.SelectedValue.ToString();
            hostdetail.ClinicBranch = cBxSelectClinic.SelectedValue.ToString();
            hostdetail.FullName = cBxSelectDoctor.SelectedValue.ToString();

            ListViewItem listitem = new ListViewItem();
            listitem.Tag = hostdetail;
            listitem.Text = hostdetail.FullName;
            listitem.SubItems.Add(dTPAppointmentDate.Value.ToShortDateString());
            listitem.SubItems.Add(hostdetail.HospitalName.ToString());
            listitem.SubItems.Add(hostdetail.ClinicBranch.ToString());

            lstVAppointmentList.Items.Add(listitem);

        }
        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            lstVAppointmentList.Visible = true;
            groupAppointment.Visible = true;
            lblDoctorName.Visible = true;

            lblDoctorName.Text = cBxSelectDoctor.SelectedValue.ToString();
            TimeFill();
              
            ListAdd();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Clear()
        {
            
            cBxSelectCity.Text = "Lütfen il seçiniz";
            cBxSelectClinic.Text = "Lütfen klinik seçiniz";
            cBxSelectDoctor.Text = "Lütfen doktor seçiniz";
            cBxSelectHospital.Text = "Lütfen hastane seçiniz";
            cBxSelectTown.Text = "Lütfen ilçe seçiniz";
            lblDoctorName.Visible = false;
            lstVAppointmentList.Visible = false;
            pictureBox1.Visible = false;
            groupAppointment.Visible = false;
            pictureBox2.Visible = true;

        }

     
        private void btnLastAppointment_Click(object sender, EventArgs e)
        {
            AppointmentStatusListForm statusListForm = new AppointmentStatusListForm();
            statusListForm._userID = _userID;
            statusListForm.Show();
            this.Hide();
        }

        private void cBxSelectCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            HospitalDetail hostd = (HospitalDetail)cBxSelectCity.SelectedValue;

            cBxSelectTown.DataSource = hospitalBLL.GetTownAll(hostd.CityID);


        }

        private void cBxSelectTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            HospitalDetail hostcity = (HospitalDetail)cBxSelectCity.SelectedValue;
            HospitalDetail hostd = (HospitalDetail)cBxSelectTown.SelectedValue;

            cBxSelectHospital.DataSource = hospitalBLL.GetHospitalAll(hostcity.CityID, hostd.TownID);

        }

        private void cBxSelectClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            HospitalDetail hostcity = (HospitalDetail)cBxSelectCity.SelectedValue;
            HospitalDetail hosttown = (HospitalDetail)cBxSelectTown.SelectedValue;
            HospitalDetail hosthospital = (HospitalDetail)cBxSelectHospital.SelectedValue;
            HospitalDetail hostclinic = (HospitalDetail)cBxSelectClinic.SelectedValue;

            cBxSelectDoctor.DataSource = hospitalBLL.GetDoctorAll(hostcity.CityID, hosttown.TownID, hosthospital.HospitalID, hostclinic.ClinicID);
        }


        private void cBxSelectHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            HospitalDetail hostcity = (HospitalDetail)cBxSelectCity.SelectedValue;
            HospitalDetail hosttown = (HospitalDetail)cBxSelectTown.SelectedValue;
            HospitalDetail hosthospital = (HospitalDetail)cBxSelectHospital.SelectedValue;

            cBxSelectClinic.DataSource = hospitalBLL.GetClinicAll(hostcity.CityID, hosttown.TownID, hosthospital.HospitalID);

        }

        private void lstVAppointmentList_DoubleClick(object sender, EventArgs e)
        {
            


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = new DialogResult();
            exit = MessageBox.Show("Sistemden Çıkmak İstediğinize Eminmisiniz?","Güvenli Çıkış!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
