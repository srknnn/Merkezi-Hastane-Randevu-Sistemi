using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class AppointmentAllDAL 
    {
        SqlCommand _command;

        public List<AppointmentALL> AppointAllList(int userid)
        {
            List<AppointmentALL> appointALList = new List<AppointmentALL>();
            _command.Parameters.Clear();
            _command.CommandText = "sp_AppointList";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.Add("@UserID", userid);
            
            
            try
            {
                if (_command.Connection.State == ConnectionState.Closed)
                    _command.Connection.Open();

                SqlDataReader reader = _command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AppointmentALL appointAll = new AppointmentALL();
                        appointAll.AppointmentID = (int)reader[0];
                        appointAll.DoctorFullName = reader[1].ToString();
                        appointAll.AppointmentDate = (DateTime)reader[2];
                        appointAll.AppointmentStatus = (bool)reader[3];
                        appointAll.AppointmentTime = DateTime.Parse(reader[4].ToString());
                        appointAll.HospitalName = reader[5].ToString();
                        appointAll.ClinicBranch = reader[6].ToString();

                        appointALList.Add(appointAll);
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
            return appointALList;


        }


        public AppointmentAllDAL()
        {
            _command = SqlHelper.CreateSqlCommand();
        }

    }
}
