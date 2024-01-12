using Logic.Classes.Orders;
using Logic.Classes.ProductOrder;
using Logic.Classes.Products;
using Logic.Enums;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
	public class DBOrderManager : IDBOrderManager
	{
		private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";
        private DBProductOrderManage DBProductOrderManage = new DBProductOrderManage();

		public void CreateAnOrder(Order order, int id) 
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			sqlConnection.Open();

			string query = "insert into [dbo].[order] (date_and_time, customer_id, order_type_id) values (@date_and_time, @customer_id, @order_type_id)";
			SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			sqlCommand.Parameters.AddWithValue("@date_and_time", order.DateAndTime);
			sqlCommand.Parameters.AddWithValue("@customer_id", id);
			sqlCommand.Parameters.AddWithValue("@order_type_id", order.OrderType);

			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

        public int ReadOrderId(int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select id from [dbo].[order] where customer_id=@customerId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerId", customerId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int id = sqlDataReader.GetInt32(0);

                return id;
            }
            sqlConnection.Close();

            return 0;
        }

        public List<Order> ReadAllOrders(int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<Order> orders = new List<Order>();
            sqlConnection.Open();

            string query = " select * from [dbo].[order] where customer_id=@customerId and order_type_id=2";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerId", customerId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                OrderType orderType = Enum.Parse<OrderType>(sqlDataReader.GetInt32(7).ToString());

                Order order = new Order(sqlDataReader.GetInt32(0), orderType, DBProductOrderManage.ReadProductOrder(sqlDataReader.GetInt32(0)));

                orders.Add(order);
            }
            sqlConnection.Close();

            return orders;
        }

        public Order ReadCart(int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = " select * from [dbo].[order] where customer_id=@customerId and order_type_id=1";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@customerId", customerId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                OrderType orderType = Enum.Parse<OrderType>(sqlDataReader.GetInt32(6).ToString());

                Order order = new Order(sqlDataReader.GetInt32(0), orderType, DBProductOrderManage.ReadProductOrder(sqlDataReader.GetInt32(0)));

                return order;
            }
            sqlConnection.Close();
            return null;
        }

        public List<PaymentMethod> ReadAllPaymentMethods()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

            sqlConnection.Open();

            string query = " select * from payment_method";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                PaymentMethod paymentMethod = new PaymentMethod();
                paymentMethod = Enum.Parse<PaymentMethod>(sqlDataReader.GetString(1));
                paymentMethods.Add(paymentMethod);
            }

            sqlConnection.Close();

            return paymentMethods;
        }

        public void UpdateOrder(Order order)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "Update [dbo].[order] SET order_status_id=@order_status_id, total_oder_price=@total_oder_price, payment_method_id=@payment_method_id, order_type_id=@order_type_id where id='" + order.Id + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@order_status_id", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@total_oder_price", order.TotalOrderPrice);
            sqlCommand.Parameters.AddWithValue("@payment_method_id", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@order_type_id", order.OrderType);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
