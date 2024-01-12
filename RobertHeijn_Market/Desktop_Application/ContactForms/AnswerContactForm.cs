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
	public partial class AnswerContactFormForm : Form
	{
		private IWebsiteAdministratorContactFormManager websiteAdministratorContactFormManager;

		public AnswerContactFormForm()
		{
			InitializeComponent();

			websiteAdministratorContactFormManager = new ContactFormManager(new DBContactFormManager());
		}
	}
}
