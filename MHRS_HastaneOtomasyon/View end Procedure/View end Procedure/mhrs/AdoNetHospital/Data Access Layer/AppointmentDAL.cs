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
            _command.CommandText = "sp_InsertAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@appointmentDate", item.AppointmenDate);
            _command.Parameters.AddWithValue("@appointmentTime", item.AppointTime);
            _command.Parameters.AddWithValue("@appointmentStatus", item.AppointStatus);

            _command.Parameters.Clear();
            
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                affectedRows = _command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                throw new Exception ("Ekleme Başarısız!");
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

            _command.CommandText = "sp_UpdateAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@appointmentDate", item.AppointmenDate);
            _command.Parameters.AddWithValue("@appointmentTime", item.AppointTime);
            _command.Parameters.AddWithValue("@appointStatus", item.AppointStatus);
            _command.Parameters.AddWithValue("@doctorID", item.DoctorID);
            _command.Parameters.AddWithValue("@patientID", item.PatientID);
            _command.Parameters.AddWithValue("@appointID", item.AppointmentID);

            _command.Parameters.Clear();

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
            int affectedRows = 0;
            if (item == null)
                return affectedRows;

            _command.CommandText = "sp_DeleteAppointment";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@appointmentDate", item.AppointmenDate);
            _command.Parameters.AddWithValue("@appointmentTime", item.AppointTime);
            _command.Parameters.AddWithValue("@appointStatus", item.AppointStatus);
            _command.Parameters.AddWithValue("@doctorID", item.DoctorID);
            _command.Parameters.AddWithValue("@patientID", item.PatientID);
            _command.Parameters.AddWithValue("@appointID", item.AppointmentID);

            _command.Parameters.Clear();

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

        public List<Appointment> GelAll()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            _command.CommandText = "vW_GetAllAppointment";
   


            SqlDataReader reader = _command.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment();
                        appointment.AppointmentID = (int)reader[0];
                        appointment.PatientID = (int)reader[1];
                        appointment.DoctorID = (int)reader[2];
                        appointment.AppointmenDate = DateTime.Parse(((DateTime)reader[3]).ToShortDateString());
                        appointment.AppointTime = DateTime.Parse(((DateTime)reader[4]).ToShortTimeString());
                        appointment.AppointStatus = (bool)reader[5];

                        appointmentList.Add(appointment);
                        

                    }
                }
                reader.Close();

            }
            catch (Exception)
            {
                
                throw new Exception ("İşlem Başarısız!");
            }
            finally
            {
                _command.Connection.Close();                    

            }
            return appointmentList;
                
        }

        public Appointment Get(int id)
        {
            Appointment appointment = null;
            _command.CommandText = "vW_GetIDAppointment";
    
           
           

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        appointment = new Appointment();
                        appointment.AppointmentID = (int)reader[0];
                        appointment.DoctorID = (int)reader[1];
                        appointment.PatientID = (int)reader[2];
                        appointment.AppointmenDate = DateTime.Parse(((DateTime)reader[3]).ToShortDateString());
                        appointment.AppointTime = DateTime.Parse(((DateTime)reader[4]).ToShortTimeString());
                        appointment.AppointStatus =(bool)reader[5];
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
            return appointment;
        }
    }
}
