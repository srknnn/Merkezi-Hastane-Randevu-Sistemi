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
    class HospitalDetailDAL:IDATAMapper<HospitalDetail,Int32>
    {
        SqlCommand _command;

        public HospitalDetailDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }
        public int Insert(HospitalDetail item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;

            _command.CommandText = "sp_asd";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@id",item.CityID);
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

        public int Update(HospitalDetail item)
        {
            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            _command.CommandText = "sp_sadsa";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@id",item.CityID);
            _command.Connection.Close();
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

        public int Delete(HospitalDetail item)
        {

            int affectedRows = 0;
            if (item == null)
                return affectedRows;
            _command.CommandText = "sp_sadsa";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@id", item.CityID);
            _command.Connection.Close();
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

        public List<HospitalDetail> GelAll()
        {
            List<HospitalDetail> hospitalDetailList = new List<HospitalDetail>();
            _command.CommandText = "sp_asdasd";
            _command.CommandType = CommandType.StoredProcedure;
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
                        HospitalDetail hospitalDetail = new HospitalDetail();
                        hospitalDetail.CityID = (int)reader[0];
                        hospitalDetail.CityName = (string)reader[1];
                        hospitalDetail.ClinicBranch =(string) reader[2];
                        hospitalDetail.ClinicID = (int)reader[3];
                        hospitalDetail.FirstName = (string)reader[4];
                        hospitalDetail.LastName = (string)reader[5];                      
                        hospitalDetail.DoctorID = (int)reader[6];
                        hospitalDetail.HospitalID = (int)reader[7];
                        hospitalDetail.HospitalName = (string)reader[8];
                        hospitalDetail.TittleID = (int)reader[9];
                        hospitalDetail.TittleName = (string)reader[10];
                        hospitalDetail.TownID = (int)reader[11];
                        hospitalDetail.TownName = (string)reader[12];

                        hospitalDetailList.Add(hospitalDetail);
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
            return hospitalDetailList;

        }

        public HospitalDetail Get(int id)
        {
            HospitalDetail hospitalDetail = null;
            _command.CommandText = "sp_asd";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@ID", id);
            _command.Parameters.Clear();
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        hospitalDetail = new HospitalDetail();
                        hospitalDetail.CityID = (int)reader[0];
                        hospitalDetail.CityName = (string)reader[1];
                        hospitalDetail.ClinicBranch = (string)reader[2];
                        hospitalDetail.ClinicID = (int)reader[3];
                        hospitalDetail.FirstName = (string)reader[4];
                        hospitalDetail.LastName = (string)reader[5];
                        hospitalDetail.DoctorID = (int)reader[6];
                        hospitalDetail.HospitalID = (int)reader[7];
                        hospitalDetail.HospitalName = (string)reader[8];
                        hospitalDetail.TittleID = (int)reader[9];
                        hospitalDetail.TittleName = (string)reader[10];
                        hospitalDetail.TownID = (int)reader[11];
                        hospitalDetail.TownName = (string)reader[12];

                        

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
            return hospitalDetail;
        }
    }
}
