using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeeklyTask_API.Models;
using System.Data.SqlClient;

namespace WeeklyTask_API.Services
{
    public class Connection_Class
    {
        protected string Connection_String = "Data Source=(local);Initial Catalog=WeeklyTask_API;Integrated Security=True;";
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;

        protected void connection()
        {
            sqlConnection = new SqlConnection(Connection_String);
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }
    }
}