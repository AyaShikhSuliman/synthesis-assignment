using Data;
using Logic.Classes.Accounts.Adminstrator;
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

namespace Desktop_Application.Administrators.Desktop
{
	public partial class GeneralDesktopAdministratorForm : Form
	{
		private IDesktopAdministratorManager desktopAdministratorManager;

		public GeneralDesktopAdministratorForm()
		{
			InitializeComponent();

			desktopAdministratorManager = new DesktopAdministratorManager(new DBDesktopAdministratorManager());
		}
	}
}
