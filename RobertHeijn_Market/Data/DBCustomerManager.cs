using Logic.Classes.Accounts.Customer;
using Logic.Classes.Orders;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBCustomerManager : IDBCustomerManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";
        private DBOrderManager DBOrderManager = new DBOrderManager();

        public List<Customer> ReadAllCustomers()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            List<Customer> customers = new List<Customer>();
            //try
            //{
                sqlConnection.Open();

                string query = " select * from customer";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Customer customer = new Customer(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetInt32(4), sqlDataReader.GetString(5), sqlDataReader.GetString(6));

                    customers.Add(customer);
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

            return customers;
        }

        public bool ReadCustomer(string emailAddress, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //try
            //{
                string query = "select * from customer where email_address='" + emailAddress + "'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Customer customer = new Customer(sqlDataReader.GetString(3), (sqlDataReader.GetString(5)), sqlDataReader.GetString(6));

                    if (emailAddress == customer.EmailAddress && customer.Password == password)
                    {
                        return true;
                    }

                }
            //}
            //catch
            //{
            //    return false;
            //}
            //finally
            //{
                sqlConnection.Close();
            //}

            return false;
        }

        public Customer ReadCustomer(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //try
            //{
                sqlConnection.Open();

                string query = "select id, email_address, password, salt from customer where customer.id=@id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@id", id);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Customer customer = new Customer(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), DBOrderManager.ReadAllOrders(sqlDataReader.GetInt32(0)));

                    return customer;
                }
            //}
            //catch
            //{
            //    return null;
            //}
            //finally
            //{
            //    sqlConnection.Close();
            //}

            return null;
        }

        public void CreateCustomer(Customer customer)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //try
            //{
                sqlConnection.Open();

                string query = "insert into customer values (@name, @last_name, @email_address, @phone_number, @password, @salt)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@name", customer.Name);
                sqlCommand.Parameters.AddWithValue("@last_name", customer.LastName);
                sqlCommand.Parameters.AddWithValue("@email_address", customer.EmailAddress);
                sqlCommand.Parameters.AddWithValue("@phone_number", customer.PhoneNumber);
                sqlCommand.Parameters.AddWithValue("@password", customer.Password);
                sqlCommand.Parameters.AddWithValue("@salt", customer.SaltPassword);

                sqlCommand.ExecuteNonQuery();

                //return "success";
            //}
            //catch (Exception ex)
            //{
            //    return ex.ToString();
            //}
            //finally
            //{
                sqlConnection.Close();

            //}
        }

        public void UpdateCustomer(Customer customer)
        {
            //SqlConnection sqlConnection = new SqlConnection(connectionString);
            //sqlConnection.Open();

            //string query = "Update customer SET category_id=@category_id, name=@name, current_amount=@current_amount, unit=@unit, price=@price, image=@image where id='" + product.Id + "'";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            //sqlCommand.Parameters.AddWithValue("@category_id", product.Category.Id);
            //sqlCommand.Parameters.AddWithValue("@name", product.Name);
            //sqlCommand.Parameters.AddWithValue("@current_amount", product.CurrentAmount);
            //sqlCommand.Parameters.AddWithValue("@unit", product.Unit);
            //sqlCommand.Parameters.AddWithValue("@price", product.Price);
            //sqlCommand.Parameters.AddWithValue("@image", product.Image);

            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
        }

        public string ReadSalt(string email)
        {
            string salt = "";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select salt from customer where email_address='" + email + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                salt = sqlDataReader.GetString(0);
            }
            sqlConnection.Close();

            return salt;
        }

        public int ReadCustomerId(string emailAddress)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = "select id from customer where email_address=@emailAddress";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@emailAddress", emailAddress);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                int customerId = sqlDataReader.GetInt32(0);

                return customerId;
            }
            sqlConnection.Close();

            return 0;
        }
    }
}
