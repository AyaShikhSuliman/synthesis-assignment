using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Logic.Enums;
using System.Data;
using Logic.Classes.Address;

namespace Data
{
    public class DBDesktopAdministratorManager : IDBDesktopAdministratorManager
	{
		private string connectionString = "TrustServerCertificate=True; Data Source=mssqlstud.fhict.local;Initial Catalog=dbi495487_synthesis;Persist Security Info=True;User ID=dbi495487_synthesis;Password=123456";

		public void CreateDesktopAdministrator(DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public void DeleteDesktopAdministrator(DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public List<DesktopAdministrator> ReadAllDesktopAdministrators()
		{
			//SqlConnection sqlConnection = new SqlConnection(connectionString);

			//try
			//{
			//	List<DesktopAdministrator> desktopAdministrators = new List<DesktopAdministrator>();
			//	sqlConnection.Open();

			//	string query = " select * from desktop_administrator";
			//	SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

			//	SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			//	while (sqlDataReader.Read())
			//	{
			//		Gender gender = Enum.Parse<Gender>(sqlDataReader.GetInt32(4).ToString());

			//		DesktopAdministrator desktopAdministrator = new DesktopAdministrator();
			//		Address address = GetDesktopAdministratorAddress(desktopAdministrator);

			//		desktopAdministrator = new DesktopAdministrator(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetInt32(3), gender,
			//		   sqlDataReader.GetString(5), sqlDataReader.GetInt32(6), address, sqlDataReader.GetString(7));

			//		desktopAdministrators.Add(desktopAdministrator);
			//	}

			//	return desktopAdministrators;
			//}
			//catch
			//{
			return null;
			//}
			//finally
			//{
			//	sqlConnection.Close();
			//}
		}

		public void UpdateDesktopAdministrator(DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public bool GetDesktopAdministrator(string emailAddress, string password)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			string query = "select * from desktop_administrator where email_address='" + emailAddress.Trim() + "'and password='" + password.Trim() + "'";

			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count == 1)
			{
				return true;
			}
            sqlConnection.Close();

            return false;
		}
	}
}
