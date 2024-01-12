using Data;
using Logic.Classes.ContactForms;
using Logic.Interfaces.Logic.ContactForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application.ContactForms
{
	public partial class GeneralContactFormsForm : Form
	{
		private IWebsiteAdministratorContactFormManager websiteAdministratorContactFormManager;
		
		public GeneralContactFormsForm()
		{
			InitializeComponent();

			websiteAdministratorContactFormManager = new ContactFormManager(new DBContactFormManager());
		}

		private void GeneralContactFormsForm_Load(object sender, EventArgs e)
		{

		}
	}
}
