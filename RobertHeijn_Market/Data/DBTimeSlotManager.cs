using Logic.Classes.DeliveryOption.TimeSlot;
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
    public class DBTimeSlotManager : IDBTimeSlotManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        public List<string> ReadAllReservedHomeTimeSlots(DateTime dateTime, int deliveryOptionId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            List<string> timeSlots = new List<string>();
            sqlConnection.Open();

            string query = "select start_time  from timeslot inner join delivery_option_details on timeslot.delivery_option_details_id = delivery_option_details.id where timeslot.start_time=@dateTime and delivery_option_details.id =@deliveryOptionId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@dateTime", dateTime);
            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string timeSlot = sqlDataReader.GetFieldValue<DateTime>(0).ToString();
                timeSlots.Add(timeSlot);
            }
            sqlConnection.Close();

            return timeSlots;
        }

        public List<string> ReadAllReservedPickUpSlots(DateTime dateTime, int deliveryOptionId, int locationId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            List<string> timeSlots = new List<string>();
            sqlConnection.Open();

            string query = "select start_time  from timeslot inner join delivery_option_details on timeslot.delivery_option_details_id = delivery_option_details.id inner join location  on delivery_option_details.location_id = [dbo].[location].id where timeslot.start_time=@dateTime and delivery_option_details.id =@deliveryOptionId and [dbo].[location].id =@locationId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@dateTime", dateTime);
            sqlCommand.Parameters.AddWithValue("@deliveryOptionId", deliveryOptionId);
            sqlCommand.Parameters.AddWithValue("@locationId", locationId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                string timeSlot = sqlDataReader.GetFieldValue<DateTime>(0).ToString();
                timeSlots.Add(timeSlot);
            }
            sqlConnection.Close();

            return timeSlots;
        }

        public List<string> GetOrdes()
        {
            string query = "select timeslot.start_time, count(order_delivey_option.order_id) as orders\r\nfrom timeslot inner join delivery_option_details\r\non timeslot.delivery_option_details_id = delivery_option_details.id\r\ninner join order_delivey_option\r\non delivery_option_details.id = order_delivey_option.delivery_option_detail_id\r\ngroup by timeslot.start_time\r\nhaving count(order_delivey_option.order_id) > 5\r\n";
            return null;
        }
    }
}
