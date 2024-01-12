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

namespace Desktop_Application.Administratos
{
	public partial class EditAdministratorForm : Form
	{
		private IDesktopAdministratorManager desktopAdministratorManager;

		public EditAdministratorForm()
		{
			InitializeComponent();

			desktopAdministratorManager = new DesktopAdministratorManager(new DBDesktopAdministratorManager());
		}
	}
}
