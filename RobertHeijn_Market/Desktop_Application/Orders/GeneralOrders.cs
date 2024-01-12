﻿using Data;
using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Classes.Orders;
using Logic.Interfaces.Logic.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application.Orders
{
	public partial class GeneralOrdersForm : Form
	{
		private IWebsiteAdministratorOrderManager websiteAdministratorOrderManager;

		public GeneralOrdersForm()
		{
			InitializeComponent();

			websiteAdministratorOrderManager = new OrderManager(new DBOrderManager(), new DBCustomerManager());
		}
	}
}
