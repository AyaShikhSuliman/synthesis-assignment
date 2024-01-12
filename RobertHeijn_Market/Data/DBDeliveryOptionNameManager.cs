using Logic.Classes.DeliveryOption.DeliveryOption;
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
    public class DBDeliveryOptionNameManager : IDBDeliveryOptionNameManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        public List<DeliveyOption> ReadAllDeliveryOptions()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            List<DeliveyOption> deliveyOptions = new List<DeliveyOption>();
            //try
            //{
                sqlConnection.Open();

                string query = "select * from delivery_option_name";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DeliveyOption deliveyOption = new Logic.Classes.DeliveryOption.DeliveryOption.DeliveyOption(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));

                    deliveyOptions.Add(deliveyOption);
                }
            //}
            //catch
            //{
            //    return null;
            //}
            //finally
            //{
                sqlConnection.Close();

            //}

            return deliveyOptions;
        }

        public int ReadDeliveOptionId(string deliveryOptionName)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select id from [dbo].[delivery_option_name] where name=@deliveryOptionName";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@deliveryOptionName", deliveryOptionName);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int deliveryOptionId = sqlDataReader.GetInt32(0);

                return deliveryOptionId;
            }
            sqlConnection.Close();

            return 0;
        }
    }
}
