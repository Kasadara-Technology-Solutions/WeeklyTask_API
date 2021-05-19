using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeeklyTask_API.Models;

namespace WeeklyTask_API.Services
{
    public class Edit_Service : Connection_Class
    {
        // Update : Order 
        public void EditOrder(Order order)
        {
            connection();
            string procedure = "EditOrder";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id", order.ID);
            sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerID);
            sqlCommand.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            sqlCommand.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            sqlCommand.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            sqlCommand.Parameters.AddWithValue("@Status", order.Status);
            sqlCommand.Parameters.AddWithValue("@Comments", order.Comments);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // UPDATE : Product
        public void EditProduct(Product product)
        {
            connection();
            string procedure = "EditProduct";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@code", product.Code);
            sqlCommand.Parameters.AddWithValue("@ProductlineId", product.ProductlineID);
            sqlCommand.Parameters.AddWithValue("@Name", product.Name);
            sqlCommand.Parameters.AddWithValue("@Scale", product.Scale);
            sqlCommand.Parameters.AddWithValue("@Vendor", product.Vendor);
            sqlCommand.Parameters.AddWithValue("@PdtDescription", product.PdtDescription);
            sqlCommand.Parameters.AddWithValue("@QtyInStock", product.QtyInStock);
            sqlCommand.Parameters.AddWithValue("@BuyPrice", product.BuyPrice);
            sqlCommand.Parameters.AddWithValue("@MSRP", product.MSRP);

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // UPDATE : Customer
        public void EditCustomer(Customer customer)
        {
            connection();
            string procedure = "EditCustomer";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", customer.ID);
            sqlCommand.Parameters.AddWithValue("@salesRepEmployeeNum", customer.salesRepEmployeeNum);
            sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@FristName", customer.FristName);
            sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", customer.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", customer.Address2);
            sqlCommand.Parameters.AddWithValue("@City", customer.City);
            sqlCommand.Parameters.AddWithValue("@State", customer.State);
            sqlCommand.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Country", customer.Country);
            sqlCommand.Parameters.AddWithValue("@CreditLimit", customer.CreditLimit);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // UPDATE : Office 
        public void EditOffice(Office office)
        {
            connection();
            string procedure = "EditCustomer";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Code", office.ID);
            sqlCommand.Parameters.AddWithValue("@City", office.City);
            sqlCommand.Parameters.AddWithValue("@Phone", office.Phone);
            sqlCommand.Parameters.AddWithValue("@Address1", office.Address1);
            sqlCommand.Parameters.AddWithValue("@Address2", office.Address2);
            sqlCommand.Parameters.AddWithValue("@State", office.State);
            sqlCommand.Parameters.AddWithValue("@Country", office.Country);
            sqlCommand.Parameters.AddWithValue("@PostalCode", office.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Territory", office.Territory);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        // UPDATE : Employee
        public void EditEmployee(Employee employee)
        {
            connection();
            string procedure = "EditEmployee";
            sqlCommand.CommandText = procedure;
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", employee.ID);
            sqlCommand.Parameters.AddWithValue("@OfficeCode", employee.OfficeCode);
            sqlCommand.Parameters.AddWithValue("@reportsTo", employee.reportsTo);
            sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@Extension", employee.Extension);
            sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
            sqlCommand.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

    }
}