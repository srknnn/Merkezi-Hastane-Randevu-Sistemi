using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class SqlHelper
    {
   
       private const string MHRSHospitalAutomationConnectionString = "server=213.14.92.74;database=alfa_v2_adonet_red_db;User ID =alfa_v2_adonet_red_user;password=s3uMUBru;";
      
       
        public static SqlCommand CreateSqlCommand()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = MHRSHospitalAutomationConnectionString;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;

    }
    }
}

