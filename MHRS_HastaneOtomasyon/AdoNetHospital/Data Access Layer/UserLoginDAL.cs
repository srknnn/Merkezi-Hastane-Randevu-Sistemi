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
    public class UserLoginDAL : IDataUserMapper<UserLogin, Int32>
    {
        SqlCommand _command;

        public UserLoginDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

        public UserLogin GetLogin(int id)
        {
            UserLogin getUserLogin = null;
            _command.Parameters.Clear();
            _command.CommandText = "select PatientID,IdentityNumber,Password from vW_GetPatient Where PatientID=@PatientId";
            _command.Parameters.AddWithValue("@PatientId", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getUserLogin = new UserLogin();
                        getUserLogin.UserID = (int)reader[0];
                        getUserLogin.IdentityNumber = (int)reader[1];
                        getUserLogin.Password = (string)reader[2];
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
            return getUserLogin;
        }


        


        public UserLogin GetUserIDentity(int id)
        {
            UserLogin getUserIdentity = null;
            _command.Parameters.Clear();
            _command.CommandText = "select PatientID,IdentityNumber,Password from vW_GetPatient Where PatientID=@PatientId";
            _command.Parameters.AddWithValue("@PatientId", id);
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        getUserIdentity = new UserLogin();
                        getUserIdentity.UserID = (int)reader[0];
                        getUserIdentity.IdentityNumber = (int)reader[1];
                        getUserIdentity.Password = reader[2].ToString();

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
            return getUserIdentity;
        }



        public List<UserLogin> GetUserALL()
        {
            List<UserLogin> userList = new List<UserLogin>();
            _command.Parameters.Clear();
            _command.CommandText = "select PatientID,IdentityNumber,Password,Email from vW_GetPatient";

            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLogin userGetALL = new UserLogin();
                        userGetALL.UserID = (int)reader[0];
                        userGetALL.IdentityNumber = long.Parse(reader[1].ToString());
                        userGetALL.Password = reader[2].ToString();
                        userGetALL.Email = reader[3].ToString();

                        userList.Add(userGetALL);
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
            return userList;
        }
    }
}
