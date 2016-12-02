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
        /*Yiğit*/
       // private const string MHRSHospitalAutomationConnectionString = "server=DESKTOP-PKHMVN9\\SQLEXPRESS;database=MHRSHospital;Integrated security=true;";
        ///*Serkan*/private const string NorthwindConnectionString = "server=YIWIT-YIWIT\\EXPRESS;database=MHRSHospitalAutomation;Integrated security=true;";
        ///*Ayça*/private const string NorthwindConnectionString = "server=YIWIT-YIWIT\\EXPRESS;database=MHRSHospitalAutomation;Integrated security=true;";

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

