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
        // GetAllOrders
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
                or.Status = Convert.ToString(dataReader[4]);
                or.Comments = Convert.ToString(dataReader[5]);
                or.ShippedDate = Convert.ToString(dataReader[6]);
                Orders.Add(or);
            }
            sqlConnection.Close();
            return Orders;
        }

        // GetOrderByID

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
                or.Status = Convert.ToString(dataReader[4]); 
                or.Comments = Convert.ToString(dataReader[5]);
                or.ShippedDate = Convert.ToString(dataReader[6]);
                Orders.Add(or);
            }
            sqlConnection.Close();
            return Orders;
        }

        // GetOrderByCustomerID

        public List<Order> GetOrderByCustomerID(int ID)
        {
            connection();
            List<Order> Orders = new List<Order>();
            sqlCommand.CommandText = "select * from [Order] where CustomerID = @ID";
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
                or.Status = Convert.ToString(dataReader[4]);
                or.Comments = Convert.ToString(dataReader[5]);
                or.ShippedDate = Convert.ToString(dataReader[6]);
                Orders.Add(or);
            }
            sqlConnection.Close();
            return Orders;
        }

        public List<Order> ListOrdersBySalesRepEmployeeNum(int ID)
        {
            connection();
            List<Order> orders = new List<Order>();
            sqlCommand.CommandText = "select * from dbo.[Order] as O left join dbo.[Customer] as C on O.CustomerID = C.ID where C.SalesRepEmployeeNumber=@ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Order order = new Order();
                Customer customer = new Customer();
                order.ID = Convert.ToInt32(dataReader["ID"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerID"]);
                order.OrderDate = Convert.ToString(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToString(dataReader[3]);
                order.Status = Convert.ToString(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                order.ShippedDate = Convert.ToString(dataReader["ShippedDate"]);
                customer.ID = Convert.ToInt32(dataReader["Id"]);
                customer.salesRepEmployeeNum = Convert.ToInt32(dataReader["SalesRepEmployeeNumber"]);
                customer.Name = Convert.ToString(dataReader["Name"]);
                customer.LastName = Convert.ToString(dataReader["LastName"]);
                customer.FristName = Convert.ToString(dataReader["FirstName"]);
                customer.Phone = Convert.ToString(dataReader["Phone"]);
                customer.Address1 = Convert.ToString(dataReader["Address1"]);
                customer.Address2 = Convert.ToString(dataReader["Address2"]);
                customer.City = Convert.ToString(dataReader["City"]);
                customer.State = Convert.ToString(dataReader["State"]);
                customer.PostalCode = Convert.ToString(dataReader["PostalCode"]);
                customer.Country = Convert.ToString(dataReader["Country"]);
                customer.CreditLimit = Convert.ToString(dataReader["CreditLimit"]);
                order.customer = customer;
                orders.Add(order);
            }
            sqlConnection.Close();
            return orders;
        }



    }
}