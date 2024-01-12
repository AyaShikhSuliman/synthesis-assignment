using Data;
using Logic.Classes.Accounts;
using Logic.Classes.Accounts.Adminstrator;
using Logic.Classes.Accounts.Customer;
using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Customers;

namespace Desktop_Application
{
	public partial class LoginForm : Form
	{
		private IDesktopAdministratorManager desktopAdministratorManager;
		private IWebsiteAministratorManager websiteAministratorManager;
		private IWebsiteAdministratorCustomerManager websiteAdministratorCustomerManager;

		public LoginForm()
		{
			InitializeComponent();

			desktopAdministratorManager = new DesktopAdministratorManager(new DBDesktopAdministratorManager());
			websiteAministratorManager = new WebsiteAdministratorManager(new DBWebsiteAdministratorManager());
            websiteAdministratorCustomerManager = new CustomerManager(new DBCustomerManager());
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string emailAddress = tbEmailAddress.Text;
			string password = tbPassword.Text;

			if (websiteAdministratorCustomerManager.ValidateEmail(emailAddress))
			{
				if (rbDesktopAdministrator.Checked)
				{
					desktopAdministratorManager.LoginAsDesktopAdministrator(emailAddress, password);

					DesktopAdministratorLoginOptionsForm loginOptionsForm = new DesktopAdministratorLoginOptionsForm();
					loginOptionsForm.Show();
					this.Hide();
				}
				else if (rbWebsiteAdministrator.Checked)
				{
					websiteAministratorManager.LoginAsWebsiteAdministrator(emailAddress, password);

					WebsiteAdministratorLoginOptionsForm websiteAdministratorLoginOptionsForm = new WebsiteAdministratorLoginOptionsForm();
					websiteAdministratorLoginOptionsForm.Show();
					this.Hide();
				}
				else if (rbCutsomer.Checked)
				{
					MessageBox.Show("A customer cannot acces the desktop application!");
					return;
				}
			}
			else
			{
				MessageBox.Show("Email address is not valid!");
			}
		}

		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}