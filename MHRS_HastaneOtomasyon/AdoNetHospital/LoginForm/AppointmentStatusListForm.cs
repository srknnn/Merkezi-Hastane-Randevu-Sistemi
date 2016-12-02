using BusinessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class AppointmentStatusListForm : Form
    {

        AppointmentBLL _apoBLL;
        AppointmentAllBLL _apoAllBLL;
        public int _userID;
        SqlCommand _command;
        Appointment apo;


        public AppointmentStatusListForm()
        {
            InitializeComponent();
         
            _apoBLL = new AppointmentBLL();
            _apoAllBLL = new AppointmentAllBLL();
            _command = new SqlCommand();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (apo != null)
            {
                DialogResult = MessageBox.Show("Randevunuzu İptal Etmek İstiyormusunuz?", "Randevu İptal", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == DialogResult)
                {
                    bool save = _apoBLL.Update(apo);
                    if (save)
                    {
                        MessageBox.Show("Randevunuz İptal edilmiştir.");
                        GetAppointmentList();

                    }
                    else
                    {
                        MessageBox.Show("Randevunuz iptal edilemedi!");
                    }
                }

            }
            else 
            {
                MessageBox.Show("Randevu Seçmeden İptal Edemessiniz!");
            }
        }

        private void btnBackForm_Click(object sender, EventArgs e)
        {
            AppointmentSave appointsave = new AppointmentSave();
            appointsave._userID = _userID;
            appointsave.Show();
            this.Hide();
        }

        private void AppointmentStatusListForm_Load(object sender, EventArgs e)
        {
            GetAppointmentList();
           
        }

        private void dgvAppointmenList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {  
              apo=new Appointment();
              apo.AppointmentID =(int) dgvAppointmenList.CurrentRow.Cells[0].Value;
        }

        void GetAppointmentList()
        {
            dgvAppointmenList.DataSource = _apoAllBLL.GetAppointmentAll(_userID);
        }

        private void dgvAppointmenList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            apo = new Appointment();
            apo.AppointmentID = (int)dgvAppointmenList.CurrentRow.Cells[0].Value;
        }
    }
}
