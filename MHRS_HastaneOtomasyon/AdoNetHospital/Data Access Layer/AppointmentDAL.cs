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
    public class AppointmentDAL : IDATAMapper<Appointment, Int32>
    {
        SqlCommand _command;
        
        public AppointmentDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public int Insert(Appointment item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;

            _command.Parameters.Clear();
            _command.CommandText = "sp_AddAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@PatientId", item.PatientID);
            _command.Parameters.AddWithValue("@DoctorId", item.DoctorID);
            _command.Parameters.AddWithValue("@AppointmentDate", item.AppointmenDate);
            _command.Parameters.AddWithValue("@AppointmentTime", item.AppointTime);
           


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

        public int Update(Appointment item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            _command.Parameters.Clear();
            
           
            _command.CommandText = "sp_UpdateAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@AppointmentID", item.AppointmentID);
           
          
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

        public int Delete(Appointment item)
        {

        throw new NotImplementedException();
        }

        public Appointment GetHospital(int id)
        {
            Appointment getHospitalID = null;
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
                        getHospitalID = new Appointment();
                        getHospitalID.DoctorID = (int)reader[0];

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

        public List<Appointment> GetCityAll()
        {
            List<Appointment> cityList = new List<Appointment>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT CityID,CityName from vW_GetAppointment";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Appointment appointmentCity = new Appointment();
                        appointmentCity.DoctorID = (int)reader[0];



                        cityList.Add(appointmentCity);
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

        public List<Appointment> GetTownAll()
        {
            List<Appointment> townList = new List<Appointment>();
            _command.Parameters.Clear();
            _command.CommandText = "select DISTINCT TownID,TownName from vW_GetAppointment";



            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Appointment appointmentTown = new Appointment();
                        appointmentTown.DoctorID = (int)reader[0];


                        townList.Add(appointmentTown);
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

        public List<Appointment> GetClinicAll()
        {
            List<Appointment> clinicList = new List<Appointment>();
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
                        Appointment appointmentClinic = new Appointment();
                        appointmentClinic.DoctorID = (int)reader[0];


                        clinicList.Add(appointmentClinic);
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

        public List<Appointment> GetHospitalAll()
        {
            List<Appointment> hospitalList = new List<Appointment>();
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
                        Appointment appointmentHospital = new Appointment();
                        appointmentHospital.DoctorID = (int)reader[0];



                        hospitalList.Add(appointmentHospital);
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

        public List<Appointment> GetDoctorAll()
        {
            List<Appointment> doctorList = new List<Appointment>();
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
                        Appointment appointmentGetDoctor = new Appointment();
                        appointmentGetDoctor.DoctorID = (int)reader[0];

                        doctorList.Add(appointmentGetDoctor);
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

        public Appointment GetTown(int id)
        {
            Appointment getTownID = null;
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
                        getTownID = new Appointment();
                        getTownID.DoctorID = (int)reader[0];

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

        public Appointment GetClinic(int id)
        {
            Appointment getClinicID = null;
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
                        getClinicID = new Appointment();
                        getClinicID.DoctorID = (int)reader[0];

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

        public Appointment GetDoctor(int id)
        {
            Appointment getDoctorID = null;
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
                        getDoctorID = new Appointment();
                        getDoctorID.DoctorID = (int)reader[0];

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

        public List<Appointment> GetTownAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetClinicAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetHospitalAll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetDoctorAll(int id)
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


        public List<String> GetDoctorTimeAll(int doctorid, DateTime doctorTime)
        {
            
            List<String> doctorTimeList = new List<String>();
            _command.Parameters.Clear();
            _command.CommandText = "sp_GetAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@DoctorID", doctorid);
            _command.Parameters.AddWithValue("@AppointmentDate", doctorTime.Date);


            doctorTimeList.Clear();
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                       string timeDoctor = (reader[0]).ToString();

                       doctorTimeList.Add(timeDoctor);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
            finally
            {
                _command.Connection.Close();
            }
            return doctorTimeList;
        }


       




        }


    }

