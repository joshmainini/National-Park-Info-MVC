using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSGeek.Models;
using System.Data.SqlClient;

namespace SSGeek.DAL
{
    public class ProductSqlDAL : IProductDAL
    {
        private string connectionString;


        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Product GetProduct(int id)
        {
            Product output = new Product();
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM products Where product_id = @product_id AND product_id IS NOT NULL; SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                    cmd.Parameters.AddWithValue("@product_id", id);
                   
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product pr = new Product();
                        pr.ProductId = Convert.ToInt32(reader["product_id"]);
                        pr.Name = Convert.ToString(reader["name"]);
                        pr.Description = Convert.ToString(reader["description"]);
                        pr.Price = Convert.ToDouble(reader["price"]);
                        pr.ImageName = Convert.ToString(reader["image_name"]);
                        output = pr;
                    }
                    
                }
                
            }
            catch(SqlException ex)
            {
                throw;
            }
            return output;
        }
       
        public List<Product> GetProducts()
        {
            List<Product> output = new List<Product>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM products", connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product p = new Product();
                        p.ProductId = Convert.ToInt32(reader["product_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.Description = Convert.ToString(reader["description"]);
                        p.Price = Convert.ToDouble(reader["price"]);
                        p.ImageName = Convert.ToString(reader["image_name"]);
                        output.Add(p);
                    }
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return output;
        }

		
    }
}