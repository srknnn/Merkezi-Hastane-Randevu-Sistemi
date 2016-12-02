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
    public class HospitalDetailBLL : IBusiness<HospitalDetail, Int32>
    {
        HospitalDetailDAL _hospitalDetailDAL = new HospitalDetailDAL();
        int affectedRows;



        public bool Insert(HospitalDetail item)
        {
            throw new NotImplementedException();
        }

        public bool Update(HospitalDetail item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(HospitalDetail item)
        {
            throw new NotImplementedException();
        }
          
        public HospitalDetail GetTown(int id)
        {
            HospitalDetail town = _hospitalDetailDAL.GetTown(id);
            return town;
        }

        public HospitalDetail GetHospital(int id)
        {
            HospitalDetail hospital = _hospitalDetailDAL.GetHospital(id);
            return hospital;
        }

        public HospitalDetail GetClinic(int id)
        {
            HospitalDetail clinic = _hospitalDetailDAL.GetClinic(id);
            return clinic;
        }

        public HospitalDetail GetDoctor(int id)
        {
            HospitalDetail doctor = _hospitalDetailDAL.GetDoctor(id);
            return doctor;
        }


        public List<HospitalDetail> GetCityAll(int id)
        {
            throw new NotImplementedException();
        }

 
        /// <summary>
        /// ////////////////////
        /// </summary>
        /// <returns></returns>
        public List<HospitalDetail> GetCityAll()
        {
            List<HospitalDetail> citylist = _hospitalDetailDAL.GetCityAll();
            return citylist;
        }
        public List<HospitalDetail> GetTownAll(int cityid)
        {
            List<HospitalDetail> townlist = _hospitalDetailDAL.GetTownAll(cityid);
            return townlist;
        }

        public List<HospitalDetail> GetHospitalAll(int cityid, int townid)
        {
            List<HospitalDetail> hospitallist = _hospitalDetailDAL.GetHospitalAll(cityid,townid);
            return hospitallist;
        }

        public List<HospitalDetail> GetClinicAll(int cityid, int townid, int hospitalid)
        {
            List<HospitalDetail> cliniclist = _hospitalDetailDAL.GetClinicAll(cityid, townid,hospitalid);
            return cliniclist;
        }

        public List<HospitalDetail> GetDoctorAll(int cityid, int townid, int hospitalid, int clinicid)
        {
            List<HospitalDetail> doctorlist = _hospitalDetailDAL.GetDoctorAll(cityid, townid, hospitalid,clinicid);
            return doctorlist;
        }





        public List<HospitalDetail> GetDoctorTimeAll(int doctorid, int doctorTime)
        {
            throw new NotImplementedException();
        }
    }
}
