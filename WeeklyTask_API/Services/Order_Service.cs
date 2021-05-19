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

        // GET ListOrdersBySalesRepEmployeeNumber

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

        // GET : GetProductsByOrderID

        public List<Order_Product> GetProductsByOrderID(int ID)
        {
            connection();
            List<Order_Product> products = new List<Order_Product>();
            sqlCommand.CommandText = "select * from [Order] inner join (select p.Code, p.ID, p.Name, p.Scale, p.Ventor, p.PdtDescription, p.QtylnStock, p.BuyPrice, p.MSRP, op.OrderID, op.PriceEach, op.Qty, op.ProductCode from product as p left join Order_Product as op on p.code = op.productcode) as temp on[Order].ID = temp.OrderID where [Order].ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                Order_Product pro = new Order_Product();
                Order or = new Order();
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["Id"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Ventor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtylnStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                pro.Id = Convert.ToInt32(dataReader["Id"]);
                pro.OrderId = Convert.ToInt32(dataReader["OrderId"]);
                pro.ProductCode = Convert.ToInt32(dataReader["ProductCode"]);
                pro.Qty = Convert.ToInt32(dataReader["Qty"]);
                pro.PriceEach = Convert.ToInt32(dataReader["PriceEach"]);
                or.ID = Convert.ToInt32(dataReader["id"]);
                or.CustomerID = Convert.ToInt32(dataReader["CustomerId"]);
                or.OrderDate = Convert.ToString(dataReader["OrderDate"]);
                or.RequiredDate = Convert.ToString(dataReader["RequriedDate"]);
                or.Status = Convert.ToString(dataReader["Status"]);
                or.Comments = Convert.ToString(dataReader["Comments"]);
                or.ShippedDate = Convert.ToString(dataReader["ShippedDate"]);
                pro.product = product;
                pro.order = or;
                products.Add(pro);
            }
            sqlConnection.Close();
            return products;
        }

        // GET : GetProductsByCustomerID

        public List<Order> GetProductsByCustomerID(int ID)
        {
            connection();
            List<Order> products = new List<Order>();
            sqlCommand.CommandText = "select * from [Order] as O inner join [Customer] as C on O.ID = C.ID where C.ID = @ID ";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {

                Order order = new Order();
                Customer customer = new Customer();
                order.ID = Convert.ToInt32(dataReader["id"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerId"]);
                order.OrderDate = Convert.ToString(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToString(dataReader["RequriedDate"]);
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

                products.Add(order);
            }
            sqlConnection.Close();
            return products;
        }

        // GET : ListOrdersByOfficeSales

        public List<Order> ListOrdersByOfficeSales(int ID)
        {
            connection();
            List<Order> listofsales = new List<Order>();
            sqlCommand.CommandText = "	select * from [Office] inner join (select * from [Order] as o left join (select e.id as employeeID,e.OfficeCode,e.reportsTo,e.Lastname as employeeLastName,e.Firstname as employeeFirstName,e.Extension,e.Email,e.JobTitle,c.ID as CustomerIdentity,c.SalesRepEmployeeNumber,c.Name,c.FirstName,c.LastName,c.Phone,c.Address1,c.Address2,c.City,c.State,c.PostalCode,c.Country,c.CreditLimit from Employee as e left join Customer as c on e.id = c.SalesRepEmployeeNumber) as temp on o.CustomerID = temp.CustomerIdentity) as temp1 on Office.code = temp1.OfficeCode where Office.code = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())

            {
                Order order = new Order();
                Customer customer = new Customer();
                Employee employee = new Employee();
                order.ID = Convert.ToInt32(dataReader["id"]);
                order.CustomerID = Convert.ToInt32(dataReader["CustomerId"]);
                order.OrderDate = Convert.ToString(dataReader["OrderDate"]);
                order.RequiredDate = Convert.ToString(dataReader["RequriedDate"]);
                order.Status = Convert.ToString(dataReader["Status"]);
                order.Comments = Convert.ToString(dataReader["Comments"]);
                order.ShippedDate = Convert.ToString(dataReader["ShippedDate"]);
                customer.ID = Convert.ToInt32(dataReader["Id"]);
                customer.salesRepEmployeeNum = Convert.ToInt32(dataReader["SalesRepEmployeeNumber"]);
                customer.Name = Convert.ToString(dataReader["Name"]);
                customer.PostalCode = Convert.ToString(dataReader["PostalCode"]);
                customer.Country = Convert.ToString(dataReader["Country"]);
                customer.CreditLimit = Convert.ToString(dataReader["CreditLimit"]);
                employee.ID = Convert.ToInt32(dataReader["id"]);
                employee.OfficeCode = Convert.ToInt32(dataReader["OfficeCode"]);
                employee.reportsTo = Convert.ToInt32(dataReader["reportsTo"]);
                customer.employee = employee;
                order.customer = customer;
                listofsales.Add(order);
            }
            sqlConnection.Close();
            return listofsales;
        }

    }
}