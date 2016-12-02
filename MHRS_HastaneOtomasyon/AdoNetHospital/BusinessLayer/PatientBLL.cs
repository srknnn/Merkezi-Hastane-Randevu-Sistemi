using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;
using Data_Access_Layer;


namespace BusinessLayer
{
   public class PatientBLL : IBusiness<Patient,Int32>
    {
       PatientDAL _patientDAL = new PatientDAL();
       int affectedRows;


        public bool Insert(Patient item)
        {
           
            if (string.IsNullOrWhiteSpace(item.FullName))
                return false;
          
            affectedRows = 0;
            affectedRows = _patientDAL.Insert(item);

            return affectedRows > 0;

        }

        public bool Update(Patient item)
        {
            if (string.IsNullOrWhiteSpace(item.FullName))
                return false;

            affectedRows = 0;
            affectedRows = _patientDAL.Update(item);

            return affectedRows > 0;
        }

        public bool Delete(Patient item)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetCityAll()
        {
            throw new NotImplementedException();
        }

        public Patient Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetDoctorAll()
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetHospitalAll()
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetTownAll()
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetClinicAll()
        {
            throw new NotImplementedException();
        }


        public Patient GetTown(int id)
        {
            throw new NotImplementedException();
        }

        public Patient GetHospital(int id)
        {
            throw new NotImplementedException();
        }

        public Patient GetClinic(int id)
        {
            throw new NotImplementedException();
        }

        public Patient GetDoctor(int id)
        {
            throw new NotImplementedException();
        }


        public List<Patient> GetCityAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetDoctorAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetHospitalAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetTownAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetClinicAll(int id)
        {
            throw new NotImplementedException();
        }


        public List<Patient> GetHospitalAll(int cityid, int townid)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetClinicAll(int cityid, int townid, int hospitalid)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetDoctorAll(int cityid, int townid, int hospitalid, int clinicid)
        {
            throw new NotImplementedException();
        }


        public List<Patient> GetDoctorTimeAll(int doctorid, int doctorTime)
        {
            throw new NotImplementedException();
        }
    }
}
