using Logic.Classes.Accounts.Customer;
using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Classes.Categories;
using Logic.Classes.Products;
using Logic.Enums;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBProductManager : IDBProductManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        private DBCategoryManager DBCategoryManager = new DBCategoryManager();

        public void CreateProduct(Product product)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "insert into product values (@category_id, @name, @current_amount, @unit, @price, @image)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@category_id", product.Category.Id);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@current_amount", product.CurrentAmount);
            sqlCommand.Parameters.AddWithValue("@unit", product.Unit);
            sqlCommand.Parameters.AddWithValue("@price", product.Price);
            sqlCommand.Parameters.AddWithValue("@image", product.Image);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeleteProduct(Product product)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "Delete From product where id ='" + product.Id + "'";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<Product> ReadAllProducts()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                List<Product> products = new List<Product>();
                sqlConnection.Open();

                string query = " select * from product";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product product = new Product(sqlDataReader.GetInt32(0), DBCategoryManager.GetProductCategoryId(sqlDataReader.GetInt32(1)), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3), sqlDataReader.GetString(4), sqlDataReader.GetDouble(5), sqlDataReader.GetString(6));

                    products.Add(product);
                }
                sqlConnection.Close();

                return products;
            }

        }

        public void UpdateProduct(Product product)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "Update product SET category_id=@category_id, name=@name, current_amount=@current_amount, unit=@unit, price=@price, image=@image where id='" + product.Id + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@category_id", product.Category.Id);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@current_amount", product.CurrentAmount);
            sqlCommand.Parameters.AddWithValue("@unit", product.Unit);
            sqlCommand.Parameters.AddWithValue("@price", product.Price);
            sqlCommand.Parameters.AddWithValue("@image", product.Image);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public Product GetProduct(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select * from product where id=@id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product(sqlDataReader.GetInt32(0), DBCategoryManager.GetProductCategoryId(sqlDataReader.GetInt32(1)), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3), sqlDataReader.GetString(4), sqlDataReader.GetDouble(5), sqlDataReader.GetString(6));

                return product;
            }
            sqlConnection.Close();

            return null;
        }
    }
}
