using Logic.Enums;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBLocationManager : IDBLocationManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        public List<Location> ReadAllLocations(int deliveryOptionId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<Location> locations = new List<Location>();

            sqlConnection.Open();

            string query = "select [dbo].[location] .location from [dbo].[location] inner join  delivery_option_details on delivery_option_details.location_id = [dbo].[location].id where delivery_option_details.delivery_option_name_id =@deliveryOptionId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Location location = Enum.Parse<Location>(sqlDataReader.GetString(0));
                locations.Add(location);
            }

            sqlConnection.Close();

            return locations;
        }

        public int ReadLocationId(string locationName) 
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select id from location where location=@locationName";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@locationName", locationName);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int addressId = sqlDataReader.GetInt32(0);

                return addressId;
            }
            sqlConnection.Close();

            return 0;
        }
    }
}
