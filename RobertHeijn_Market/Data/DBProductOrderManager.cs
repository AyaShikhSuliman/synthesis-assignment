using Logic.Classes.Accounts.Customer;
using Logic.Classes.Orders;
using Logic.Classes.ProductOrder;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBProductOrderManage : IDBProductOrderManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";
        private DBProductManager DBProductManager = new DBProductManager();

        public void CreateAProductOrder(ProductOrder productOrder, int cartId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "SET IDENTITY_INSERT [dbo].[product_order] ON insert into product_order (product_id, order_id, quantity, price) values (@product_id, @order_id, @quantity, @price) select product_id, order_id, quantity, price from product_order SET IDENTITY_INSERT [dbo].[product_order] OFF";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@product_id", productOrder.Product.Id);
            sqlCommand.Parameters.AddWithValue("@order_id", cartId);
            sqlCommand.Parameters.AddWithValue("@quantity", productOrder.Quantity);
            sqlCommand.Parameters.AddWithValue("@price", productOrder.Price);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<ProductOrder> ReadProductOrder(int orderId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<ProductOrder> productOrders = new List<ProductOrder>();
            sqlConnection.Open();

            string query = " select * from product_order where order_id=@orderId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@orderId", orderId);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                ProductOrder productOrder = new ProductOrder(DBProductManager.GetProduct(sqlDataReader.GetInt32(0)), sqlDataReader.GetInt32(2), sqlDataReader.GetDouble(3));

                productOrders.Add(productOrder);
            }
            sqlConnection.Close();

            return productOrders;
        }

        public void UpdateProductOrder(ProductOrder productOrder, int orderId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                string query = "Update product_order SET quantity=@quantity, price=@price where product_id='" + productOrder.Product.Id + "' and order_id='" + orderId + "'";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@quantity", productOrder.Quantity);
                    sqlCommand.Parameters.AddWithValue("@price", productOrder.Price);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();

            }

        }


        public void DeleteProductOrder(int productId, int orderId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "Delete From product_order where product_id ='" + productId + "' and order_id = '" + orderId + "'";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public ProductOrder ReadProductOrder(int productId, int orderId)
        {
            ProductOrder order = null;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();

                string query = "select product_id, order_id, quantity, price from product_order where order_id=@orderId and product_id=@productId";

                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@productId", productId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Product product = DBProductManager.GetProduct(dr.GetInt32(0));
                    order = new ProductOrder(product, dr.GetInt32(2), dr.GetDouble(3));
                }
                return order;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();

            }
        }

        public double ReadOrderTotalPrice(int orderId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "select sum(product_order.price * product_order.quantity) as OrderTotalPrice from product_order where order_id=@orderId";
            SqlCommand cmd = new SqlCommand(query, connection);
           
            cmd.Parameters.AddWithValue("@orderId", orderId);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                double totalPrice = dr.GetDouble(0);

                return totalPrice;
            }

            return 0;
        }
    }
}
