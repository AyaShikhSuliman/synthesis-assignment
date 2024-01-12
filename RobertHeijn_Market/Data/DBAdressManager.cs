using Logic.Classes.Accounts.Customer;
using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Classes.Address;
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
    public class DBAdressManager : IDBAddressManager
    {
        private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

        //public Address GetAddress(Customer customer)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    try
        //    {
        //        sqlConnection.Open();

        //        string query = " select * from address where customer='" + customer.Id + "'";
        //        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

        //        while (sqlDataReader.Read())
        //        {
        //            Address address = new Address(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1),
        //               sqlDataReader.GetInt32(2), sqlDataReader.GetString(3), sqlDataReader.GetString(4), sqlDataReader.GetString(5));

        //            return address;
        //        }

        //        return null;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        sqlConnection.Close();
        //    }
        //}

        public void CreateAddress(Address address, int customerId)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //try
            //{
                sqlConnection.Open();

                string query = "INSERT INTO address values (@street_name, @house_number, @postcode, @country, @customer_id)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@street_name", address.StreetName);
                sqlCommand.Parameters.AddWithValue("@house_number", address.HouseNumber);
                sqlCommand.Parameters.AddWithValue("@postcode", address.Postcode);
                sqlCommand.Parameters.AddWithValue("@country", address.Country);
                sqlCommand.Parameters.AddWithValue("@customer_id", customerId);

                sqlCommand.ExecuteNonQuery();
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

        public List<Country> ReadAllCountries()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            List<Country> countries = new List<Country>();

            //try
            //{
                sqlConnection.Open();

                string query = " select * from country";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Country country = new Country();
                    country = Enum.Parse<Country>(sqlDataReader.GetString(1));
                    countries.Add(country);

                }
            //}
            //catch
            //{
            sqlConnection.Close();
            return countries;
            //}
            //finally
            //{

            //}

            //return null;
        }
    }
}
