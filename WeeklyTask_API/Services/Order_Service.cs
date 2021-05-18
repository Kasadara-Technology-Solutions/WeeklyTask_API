using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WeeklyTask_API.Models;

namespace WeeklyTask_API.Services
{
    public class Order_Service : Connection_Class
    {
        // GETAllOrders
        public List<Order>GetAllOrders()
        {
            connection();
            List<Order> Orders = new List<Order>();
            sqlCommand.CommandText = "select * from [Order]";
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order or = new Order();
                or.ID = Convert.ToInt32(dataReader[0]);
                or.CustomerID = Convert.ToInt32(dataReader[1]);
                or.RequiredDate = Convert.ToString(dataReader[2]);
                or.RequiredDate = Convert.ToString(dataReader[3]);
                or.Status = Convert.ToInt32(dataReader[4]);
                or.Comments = Convert.ToString(dataReader[5]);
                or.ShippedDate = Convert.ToString(dataReader[6]);
                Orders.Add(or);
            }
            sqlConnection.Close();
            return Orders;
        }

        // GetAllOrders

        public List<Order> GetOrderByID(int ID)
        {
            connection();
            List<Order> Orders = new List<Order>();
            sqlCommand.CommandText = "select * from [Order] where ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order or = new Order();
                or.ID = Convert.ToInt32(dataReader[0]);
                or.CustomerID = Convert.ToInt32(dataReader[1]);
                or.RequiredDate = Convert.ToString(dataReader[2]);
                or.RequiredDate = Convert.ToString(dataReader[3]);
                or.Status = Convert.ToInt32(dataReader[4]);
                or.Comments = Convert.ToString(dataReader[5]);
                or.ShippedDate = Convert.ToString(dataReader[6]);
                Orders.Add(or);
            }
            sqlConnection.Close();
            return Orders;
        }

    }
}