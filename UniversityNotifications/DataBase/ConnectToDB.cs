using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UniversityNotifications.DataBase
{
    public class ConnectToDB
    {
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["universityNotificationCon"].ConnectionString;
            }
        }

        public SqlCommand CreateCommand(string cmd,CommandType cmdType)
        {
            SqlConnection SqlCon = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(cmd, SqlCon);
            SqlCon.Open();
            sqlCmd.CommandType = cmdType;
            return sqlCmd;
        }
    }
}