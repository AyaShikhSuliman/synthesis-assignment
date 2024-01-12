using Logic.Classes.Categories;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBCategoryManager : IDBCategoryManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        public List<Category> ReadAllCategories()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<Category> categories = new List<Category>();
          
            sqlConnection.Open();

            string query = " select * from category where id=category_id";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                categories.Add(category);
            }
          
            sqlConnection.Close();

            return categories;
        }

        public List<Category> ReadSubCategories(string category)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<Category> subCategories = new List<Category>();
          
            sqlConnection.Open();

            string query = " select category.id, category.name, category.category_id from category left join category as category2 on category.category_id = category2.id where category.id!=category.category_id and category2.name= '" + category + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category subCategory = new Category(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                subCategories.Add(subCategory);

            }
        
            sqlConnection.Close();

            return subCategories;
   
        }

        public Category GetProductCategoryId(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
          
            sqlConnection.Open();

            string query = " select * from category where id='" + id + "'";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Category category = new Category(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                return category;
            }
   
            sqlConnection.Close();
            return null;
        }
    }
}
