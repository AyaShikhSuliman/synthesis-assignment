using Data;
using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application.Administrators.Website
{
	public partial class EditWebsiteAdministrator : Form
	{
		private IWebsiteAministratorManager websiteAministratorManager;

		public EditWebsiteAdministrator()
		{
			InitializeComponent();

			websiteAministratorManager = new WebsiteAdministratorManager(new DBWebsiteAdministratorManager());
		}
	}
}
