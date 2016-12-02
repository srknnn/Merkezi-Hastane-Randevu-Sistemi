using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data_Access_Layer;


namespace BusinessLayer
{
   public class AppointmentBLL : IBusiness<Appointment,Int32>
    {

       AppointmentDAL _appoDAL = new AppointmentDAL();
       int affectedRows;

        public bool Insert(Appointment item)
        {

            if (string.IsNullOrWhiteSpace(item.PatientID.ToString()) || (string.IsNullOrWhiteSpace(item.DoctorID.ToString())))
                return false;

            affectedRows = 0;
            affectedRows = _appoDAL.Insert(item);

            return affectedRows > 0;
        }

        public bool Update(Appointment item)
        {
            if (string.IsNullOrWhiteSpace(item.PatientID.ToString()) || (string.IsNullOrWhiteSpace(item.DoctorID.ToString())))
                return false;

            affectedRows = 0;
            affectedRows = _appoDAL.Update(item);

            return affectedRows > 0;
        }

        public bool Delete(Appointment item)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetCityAll()
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetTownAll(int cityid)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetHospitalAll(int cityid, int townid)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetClinicAll(int cityid, int townid, int hospitalid)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetDoctorAll(int cityid, int townid, int hospitalid, int clinicid)
        {
            throw new NotImplementedException();
        }


        public Appointment GetTown(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment GetHospital(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment GetClinic(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment GetDoctor(int id)
        {
            throw new NotImplementedException();
        }




        public List<String> GetDoctorTimeAll(int doctorid, DateTime doctorTime)
        {
            List<String> doctortimelist = _appoDAL.GetDoctorTimeAll(doctorid, doctorTime);
            return doctortimelist;
        }





    }
}
