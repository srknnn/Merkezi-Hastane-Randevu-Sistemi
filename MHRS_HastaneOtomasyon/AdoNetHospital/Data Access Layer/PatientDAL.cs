using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer
{
   public class PatientDAL : IDATAMapper<Patient, Int32>
    {
        SqlCommand _command;

        public PatientDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public int Insert(Patient item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;

            _command.Parameters.Clear();
            _command.CommandText = "sp_AddPatient";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@FirtsName", item.FirstName);
            _command.Parameters.AddWithValue("@LastName", item.LastName);
            _command.Parameters.AddWithValue("@IdentityNumber", item.IdentityNumber);
            _command.Parameters.AddWithValue("@Gender", item.gender);
            _command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth);
            _command.Parameters.AddWithValue("@Email", item.EMail);
            _command.Parameters.AddWithValue("@Password", item.Password);
            _command.Parameters.AddWithValue("@CellPhone", item.CellPhone);
            _command.Parameters.AddWithValue("@HomePhone", item.HomePhone);
            _command.Parameters.AddWithValue("@SecurityQuestion", item.SecurityQuestion);
            _command.Parameters.AddWithValue("@Answer", item.Answer);
            _command.Parameters.AddWithValue("@PlaceOfBirth", item.PlaceOfBirth);
            _command.Parameters.AddWithValue("@MotherName", item.MotherName);
            _command.Parameters.AddWithValue("@FatherName", item.FatherName);
            _command.Parameters.AddWithValue("@Picture", item.SecurityPicture);



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }

        public int Update(Patient item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            _command.Parameters.Clear();

            _command.CommandText = "sp_UpdatePatient";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@FirtsName", item.FirstName);
            _command.Parameters.AddWithValue("@LastName", item.LastName);
            _command.Parameters.AddWithValue("@IdentityNumber", item.IdentityNumber);
            _command.Parameters.AddWithValue("@Gender", item.gender);
            _command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth);
            _command.Parameters.AddWithValue("@Email", item.EMail);
            _command.Parameters.AddWithValue("@Password", item.Password);
            _command.Parameters.AddWithValue("@CellPhone", item.CellPhone);
            _command.Parameters.AddWithValue("@HomePhone", item.HomePhone);
            _command.Parameters.AddWithValue("@SecurityQuestion", item.SecurityQuestion);
            _command.Parameters.AddWithValue("@Answer", item.Answer);
            _command.Parameters.AddWithValue("@PlaceOfBirth", item.PlaceOfBirth);
            _command.Parameters.AddWithValue("@MotherName", item.MotherName);
            _command.Parameters.AddWithValue("@FatherName", item.FatherName);
            _command.Parameters.AddWithValue("@PatientId", item.ID);



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                affectedRows = _command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw new Exception("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();
            }
            return affectedRows;
        }

        public int Delete(Patient item)
        {
            return 0;
        }

        public Patient GetHospital(int id)
        {
            Patient getHospitalID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select HospitalID,HospitalName from vW_GetAppointment where HospitalID=@ID";
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
                        getHospitalID = new Patient();
                        getHospitalID.ID = (int)reader[0];

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

        public List<Patient> GetCityAll()
        {
            List<Patient> cityList = new List<Patient>();
            _command.CommandText = "select DISTINCT CityID,CityName from vW_GetAppointment";

            _command.Parameters.Clear();


            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patientGetCity = new Patient();
                        patientGetCity.ID = (int)reader[0];



                        cityList.Add(patientGetCity);
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

        public List<Patient> GetTownAll()
        {
            List<Patient> townList = new List<Patient>();
            _command.CommandText = "select DISTINCT TownID,TownName from vW_GetAppointment";

            _command.Parameters.Clear();


            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patientGetTown = new Patient();
                        patientGetTown.ID = (int)reader[0];


                        townList.Add(patientGetTown);
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

        public List<Patient> GetClinicAll()
        {
            List<Patient> clinicList = new List<Patient>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT ClinicID,ClinicBranch from vW_GetAppointment";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patientGetClinic = new Patient();
                        patientGetClinic.ID = (int)reader[0];


                        clinicList.Add(patientGetClinic);
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

        public List<Patient> GetHospitalAll()
        {
            List<Patient> hospitalList = new List<Patient>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT HospitalID,HospitalName from vW_GetAppointment";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patientGetHospital = new Patient();
                        patientGetHospital.ID = (int)reader[0];



                        hospitalList.Add(patientGetHospital);
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

        public List<Patient> GetDoctorAll()
        {
            List<Patient> doctorList = new List<Patient>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT DoctorId,DoctorFirstName,DoctorLastName from vW_GetAppointment";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patientGetDoctor = new Patient();
                        patientGetDoctor.ID = (int)reader[0];

                        doctorList.Add(patientGetDoctor);
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

        public Patient GetTown(int id)
        {
            Patient getTownID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select TownID,TownName from vW_GetAppointment where TownID=@ID";
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
                        getTownID = new Patient();
                        getTownID.ID = (int)reader[0];

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

        public Patient GetClinic(int id)
        {
            Patient getClinicID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select ClinicBranch,ClinicID from vW_GetAppointment where ClinicID=@ID";
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
                        getClinicID = new Patient();
                        getClinicID.ID = (int)reader[0];

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

        public Patient GetDoctor(int id)
        {
            Patient getDoctorID = null;
            _command.Parameters.Clear();
            _command.CommandText = "select DoctorID,DoctorFirstName,DoctorLastName from vW_GetAppointment where DoctorID=@ID";
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
                        getDoctorID = new Patient();
                        getDoctorID.ID = (int)reader[0];

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



        public List<Patient> GetTownAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetClinicAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetHospitalAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetDoctorAll(int id)
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