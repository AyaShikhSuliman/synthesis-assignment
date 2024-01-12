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
    public class DBDeliveyOptionCharacteristics : IDBDeliveryOptionCharacteristicsManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        public int ReadSlotsPerHour(int deliveryOptionId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string query = "select [slots_per_hour] from [dbo].[delivery_option_characteristics] where [delivery_option_name_id]=@deliveryOptionId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int slotPerHour = sqlDataReader.GetInt32(0);

                return slotPerHour;
            }
            sqlConnection.Close();

            return 0;
        }

        public TimeOnly ReadStartTime(int deliveryOptionId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select [start_time] from [dbo].[delivery_option_characteristics] where [delivery_option_name_id]=@deliveryOptionId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                TimeSpan timeSpan = sqlDataReader.GetTimeSpan(0);
                string timeString = timeSpan.ToString();
                TimeOnly timeOnly = TimeOnly.Parse(timeString);

                return timeOnly;
            }

            sqlConnection.Close();

            var timeNow = TimeOnly.FromDateTime(DateTime.Now);
            return timeNow;

        }


        public TimeOnly ReadEndTime(int deliveryOptionId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select [end_time] from [dbo].[delivery_option_characteristics] where [delivery_option_name_id]=@deliveryOptionId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                TimeSpan timeSpan = sqlDataReader.GetTimeSpan(0);
                string timeString = timeSpan.ToString();
                TimeOnly timeOnly = TimeOnly.Parse(timeString);

                return timeOnly;
            }

            sqlConnection.Close();
            var timeNow = TimeOnly.FromDateTime(DateTime.Now);
            return timeNow;
        }
    }
}
