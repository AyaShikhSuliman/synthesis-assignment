using Desktop_Application.Administrators.Desktop;
using Desktop_Application.Administratos;
using Desktop_Application.Products;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_Application.Administrators;
using Desktop_Application.Administrators.Website;

namespace Desktop_Application
{
	public partial class DesktopAdministratorLoginOptionsForm : Form
	{
		public DesktopAdministratorLoginOptionsForm()
		{
			InitializeComponent();
		}

		private void LoginOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}

		private void btnProducts_Click(object sender, EventArgs e)
		{
			GeneralProductsForm generalProductsForm = new GeneralProductsForm();
			generalProductsForm.Show();
			this.Hide();
		}

		private void btnAdministrators_Click(object sender, EventArgs e)
		{
			GeneralDesktopAdministratorForm generalDesktopAdministratorForm = new GeneralDesktopAdministratorForm();
			generalDesktopAdministratorForm.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GeneralWebsiteAdministratorForm generalWebsiteAdministratorForm= new GeneralWebsiteAdministratorForm();
			generalWebsiteAdministratorForm.Show();
			this.Hide();
		}
	}
}
