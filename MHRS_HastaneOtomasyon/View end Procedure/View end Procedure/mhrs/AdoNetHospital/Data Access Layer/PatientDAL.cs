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
    class PatientDAL : IDATAMapper<Patient, Int32>
    {
        SqlCommand _command;
        Patient patient;
        int affectedRows = 0;

        public List<Patient> GetAll()
        {
            List<Patient> patientList = new List<Patient>();
            _command.CommandText = "sp_BOS";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.Clear();

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();

                    SqlDataReader dataReader = new SqlDataReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            patient = new Patient();
                            patient.ID = (int)dataReader[0];
                            patient.FirstName = dataReader[1].ToString();
                            patient.LastName = dataReader[2].ToString();
                            patient.IdentityNumber = (long)dataReader[3];
                            patient.gender = (Patient.Gender)dataReader[4];
                            patient.DateOfBirth = (DateTime)dataReader[5];
                            patient.EMail = dataReader[6].ToString();
                            patient.Password = dataReader[7].ToString();
                            patient.CellPhone = (long)dataReader[8];
                            patient.HomePhone = (long)dataReader[9];
                            patient.SecurityQuestion = dataReader[10].ToString();
                            patient.Answer = dataReader[11].ToString();
                            patient.PlaceOfBirth = dataReader[12].ToString();
                            patient.MotherName = dataReader[13].ToString();
                            patient.FatherName = dataReader[14].ToString();
                            patient.IsDeleted = (bool)dataReader[15];
                            patient.SecurityPicture = dataReader[16].ToString();


                            patientList.Add(patient);
                            dataReader.Close();

                        }
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _command.Connection.Close();
            }
            return patientList;

        }

        public Patient Get(int id)
        {
            Patient town = null;
            _command.CommandText = "sp_BOS";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@id", id);

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
                SqlDataReader dataReader = _command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        patient = new Patient();
                        patient.ID = (int)dataReader[0];
                        patient.FirstName = dataReader[1].ToString();
                        patient.LastName = dataReader[2].ToString();
                        patient.IdentityNumber = (long)dataReader[3];
                        patient.gender = (Patient.Gender)dataReader[4];
                        patient.DateOfBirth = (DateTime)dataReader[5];
                        patient.EMail = dataReader[6].ToString();
                        patient.Password = dataReader[7].ToString();
                        patient.CellPhone = (long)dataReader[8];
                        patient.HomePhone = (long)dataReader[9];
                        patient.SecurityQuestion = dataReader[10].ToString();
                        patient.Answer = dataReader[11].ToString();
                        patient.PlaceOfBirth = dataReader[12].ToString();
                        patient.MotherName = dataReader[13].ToString();
                        patient.FatherName = dataReader[14].ToString();
                        patient.IsDeleted = (bool)dataReader[15];
                        patient.SecurityPicture = dataReader[16].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _command.Connection.Close();
            }
            return town;

        }



        public int Update(Patient item)
        {
            if (item == null)
                return affectedRows;
            _command.CommandText = "";
            _command.Parameters.Clear();

            _command.Parameters.AddWithValue("@FirstName", item.FirstName);
            _command.Parameters.AddWithValue("@LastName", item.LastName);
            _command.Parameters.AddWithValue("@IdentityNumber", item.IdentityNumber);
            _command.Parameters.AddWithValue("@Gender", item.gender);
            _command.Parameters.AddWithValue("@DateOfBirth", item.DateOfBirth);
            _command.Parameters.AddWithValue("@email", item.EMail);
            _command.Parameters.AddWithValue("Password", item.Password);
            _command.Parameters.AddWithValue("@Cellphone", item.CellPhone);
            _command.Parameters.AddWithValue("@Homephone", item.HomePhone);
            _command.Parameters.AddWithValue("@SecurityQuestion", item.SecurityQuestion);
            _command.Parameters.AddWithValue("@Answer", item.Answer);
            _command.Parameters.AddWithValue("@PlaceOfBirth", item.PlaceOfBirth);
            _command.Parameters.AddWithValue("@MotherName", item.MotherName);
            _command.Parameters.AddWithValue("@FatherName", item.FatherName);
           

            GetControl();
            return affectedRows;




     }
     
        
        public int Delete(Patient item)
        {
            if (item == null)
                return affectedRows;
            _command.CommandText = "";
            _command.Parameters.Clear();


            _command.Parameters.AddWithValue("IsDeleted", item.IsDeleted);
            GetControl();
            return affectedRows;

        }
        
        public void GetControl()
        {
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                {
                    _command.Connection.Open();
                }
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
        }

    }
}