using Data;
using Logic.Classes.Accounts.Customer;
using Logic.Interfaces.Logic.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
	public partial class CustomersForm : Form
	{
		private IWebsiteAdministratorCustomerManager websiteAdministratorCustomerManager;

		public CustomersForm()
		{
			InitializeComponent();

			websiteAdministratorCustomerManager = new CustomerManager(new DBCustomerManager());
		}
	}
}
