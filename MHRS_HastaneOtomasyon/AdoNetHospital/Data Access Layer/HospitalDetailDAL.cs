using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Data_Access_Layer
{
   public class HospitalDetailDAL:IDATAMapper<HospitalDetail,Int32>
    {
        SqlCommand _command;

        public HospitalDetailDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
      
        public HospitalDetail GetHospital(int id)
        {
            HospitalDetail getHospitalID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select HospitalID,HospitalName from vW_GetHospitalDetails where TownID=@ID";
            _command.Parameters.AddWithValue("@ID", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getHospitalID = new HospitalDetail();
                        getHospitalID.HospitalID = (int)reader[0];
                        getHospitalID.HospitalName = (string)reader[1];
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                
                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getHospitalID;
        }

        public HospitalDetail GetTown(int id)
        {
            HospitalDetail getTownID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select TownID,TownName from vW_GetHospitalDetails where CityID=@ID";
            _command.Parameters.AddWithValue("@ID", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getTownID = new HospitalDetail();
                        getTownID.TownID = (int)reader[0];
                        getTownID.TownName = (string)reader[1];
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getTownID;
        }

        public HospitalDetail GetClinic(int id)
        {
            HospitalDetail getClinicID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select ClinicID,ClinicBranch,ClinicStartTime,ClinicTimeRange,ClinicEndTime from vW_GetHospitalDetails where HospitalID=@ID";
            _command.Parameters.AddWithValue("@ID", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getClinicID = new HospitalDetail();
                        getClinicID.ClinicID = (int)reader[0];
                        getClinicID.ClinicBranch = (string)reader[1];
                        getClinicID.ClinicStartTime = DateTime.Parse(reader[2].ToString());
                        getClinicID.ClinicRangeTime = (int)reader[3];
                        getClinicID.ClinicEndTime = DateTime.Parse(reader[4].ToString());
                        
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getClinicID;
        }

        public HospitalDetail GetDoctor(int id)
        {
            HospitalDetail getDoctorID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select DoctorID,DoctorFirstName,DoctorLastName from vW_GetHospitalDetails where HospitalID=@ID";
            _command.Parameters.AddWithValue("@ID", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getDoctorID = new HospitalDetail();
                        getDoctorID.DoctorID = (int)reader[0];
                        getDoctorID.FullName = (string)reader[1] + " "+(string)reader[2];
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return getDoctorID;
        }

        public int Insert(HospitalDetail item)
        {
            throw new NotImplementedException();
        }

        public int Update(HospitalDetail item)
        {
            throw new NotImplementedException();
        }

        public int Delete(HospitalDetail item)
        {
            throw new NotImplementedException();
        }



        public List<HospitalDetail> GetCityAll()
        {
            List<HospitalDetail> cityList = new List<HospitalDetail>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT CityID,CityName from vW_GetHospitalDetails";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HospitalDetail hospitalGetCity = new HospitalDetail();
                        hospitalGetCity.CityID = (int)reader[0];
                        hospitalGetCity.CityName = (string)reader[1];


                        cityList.Add(hospitalGetCity);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return cityList;


        }     

        public List<HospitalDetail> GetTownAll(int cityid)
        {
            List<HospitalDetail> townList = new List<HospitalDetail>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT TownID,TownName from vW_GetHospitalDetails Where CityID=@CityID ";
            _command.Parameters.AddWithValue("@CityID", cityid);


            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HospitalDetail hospitalGetTown = new HospitalDetail();
                        hospitalGetTown.TownID = (int)reader[0];
                        hospitalGetTown.TownName = (string)reader[1];


                        townList.Add(hospitalGetTown);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return townList;
        }

        public List<HospitalDetail> GetHospitalAll(int cityid, int townid)
        {
            List<HospitalDetail> hospitalList = new List<HospitalDetail>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT HospitalID,HospitalName from vW_GetHospitalDetails where CityID=@CityID and TownID=@TownID ";
            _command.Parameters.AddWithValue("@CityID", cityid);
            _command.Parameters.AddWithValue("@TownID", townid);


            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HospitalDetail hospitalGetHospital = new HospitalDetail();
                        hospitalGetHospital.HospitalID = (int)reader[0];
                        hospitalGetHospital.HospitalName = (string)reader[1];


                        hospitalList.Add(hospitalGetHospital);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return hospitalList;
        }

        public List<HospitalDetail> GetClinicAll(int cityid, int townid, int hospitalid)
        {
            List<HospitalDetail> clinicList = new List<HospitalDetail>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT ClinicID,ClinicBranch,ClinicStartTime,ClinicTimeRange,ClinicEndTime from vW_GetHospitalDetails where CityID=@CityID and TownID=@TownID and HospitalID=@HospitalID";
            _command.Parameters.AddWithValue("@CityID", cityid);
            _command.Parameters.AddWithValue("@TownID", townid);
            _command.Parameters.AddWithValue("@HospitalID", hospitalid);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HospitalDetail hospitalGetClinic = new HospitalDetail();
                        hospitalGetClinic.ClinicID = (int)reader[0];
                        hospitalGetClinic.ClinicBranch = (string)reader[1];
                        hospitalGetClinic.ClinicStartTime = DateTime.Parse(reader[2].ToString());
                        hospitalGetClinic.ClinicRangeTime = (int)reader[3];
                        hospitalGetClinic.ClinicEndTime = DateTime.Parse(reader[4].ToString());

                        clinicList.Add(hospitalGetClinic);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return clinicList;
        }

        public List<HospitalDetail> GetDoctorAll(int cityid, int townid, int hospitalid, int clinicid)
        {
            List<HospitalDetail> doctorList = new List<HospitalDetail>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT DoctorId,DoctorFirstName,DoctorLastName from vW_GetHospitalDetails  where CityID=@CityID and TownID=@TownID and HospitalID=@HospitalID and ClinicID=@ClinicID ";
            _command.Parameters.AddWithValue("@CityID", cityid);
            _command.Parameters.AddWithValue("@TownID", townid);
            _command.Parameters.AddWithValue("@HospitalID", hospitalid);
            _command.Parameters.AddWithValue("@ClinicID", clinicid);


            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HospitalDetail hospitalGetDoctor = new HospitalDetail();
                        hospitalGetDoctor.DoctorID = (int)reader[0];
                        hospitalGetDoctor.FullName = (string)reader[1] + " " + (string)reader[2]; ;



                        doctorList.Add(hospitalGetDoctor);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return doctorList;
        }





        public List<HospitalDetail> GetDoctorTimeAll(int doctorid, int doctorTime)
        {
            throw new NotImplementedException();
        }
    }
}
