using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WeeklyTask_API.Models;


namespace WeeklyTask_API.Services
{
    
    public class Product_Services : Connection_Class
    { 
        // GetAllProduct
        public List<Product> GetAllProducts()
        {
            connection();
            List<Product> products = new List<Product>();
            sqlCommand.CommandText = "select * from [Product]";
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Code = Convert.ToInt32(dataReader[0]);
                product.ProductlineID = Convert.ToInt32(dataReader[1]);
                product.Name = Convert.ToString(dataReader[2]);
                product.Scale = Convert.ToInt32(dataReader[3]);
                product.Vendor = Convert.ToString(dataReader[4]);
                product.PdtDescription = Convert.ToString(dataReader[5]);
                product.QtyInStock = Convert.ToInt32(dataReader[6]);
                product.BuyPrice = Convert.ToInt32(dataReader[7]);
                product.MSRP = Convert.ToString(dataReader[8]);
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        // GetAllProductByID

        public List<Product> GetAllProductsByID(int ID)
        {
            List<Product> products = new List<Product>();
            connection();
            sqlCommand.CommandText = "select * from Product Left join Productline on Product.ProductlineID=Productline.ID";
            sqlCommand.Parameters.AddWithValue("@ID", ID);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Product product = new Product();
                Productline productline = new Productline();
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineID"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                productline.ID = Convert.ToInt32(dataReader["Id"]);
                productline.DesclnHTML = Convert.ToString(dataReader["DesclnHTML"]);
                productline.DesclnText = Convert.ToString(dataReader["DesclnText"]);
                productline.Image = Convert.ToString(dataReader["Image"]);
                product.productline = productline;
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        // GetProductByName 

        public Product GetProductByName(string Name)
        {
            List<Product> products = new List<Product>();
            connection();
            sqlCommand.CommandText = "select * from Product where Name = @Name";
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Product product = new Product();

            while (dataReader.Read())
            {
                product.Code = Convert.ToInt32(dataReader["Code"]);
                product.ProductlineID = Convert.ToInt32(dataReader["ProductlineId"]);
                product.Name = Convert.ToString(dataReader["Name"]);
                product.Scale = Convert.ToInt32(dataReader["Scale"]);
                product.Vendor = Convert.ToString(dataReader["Vendor"]);
                product.PdtDescription = Convert.ToString(dataReader["PdtDescription"]);
                product.QtyInStock = Convert.ToInt32(dataReader["QtyInStock"]);
                product.BuyPrice = Convert.ToInt32(dataReader["BuyPrice"]);
                product.MSRP = Convert.ToString(dataReader["MSRP"]);
                products.Add(product);
            }
            sqlConnection.Close();
            return product;
        }

    }
}
