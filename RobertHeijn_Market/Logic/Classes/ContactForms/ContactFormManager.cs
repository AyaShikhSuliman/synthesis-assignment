using Logic.Interfaces.Data;
using Logic.Interfaces.Logic.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ContactForms
{
    public class ContactFormManager : ICustomersContactFormManager, IWebsiteAdministratorContactFormManager
	{
		private IDBContactFormManager dBContactFormManager;

		public ContactFormManager(IDBContactFormManager dBContactFormManager)
		{
			this.dBContactFormManager = dBContactFormManager;
		}

		public void AnswerContactFormQuestion(ContactForm contactForm)
		{
			dBContactFormManager.UpdateContactForm(contactForm);
		}

		public void CreateAContactForm(ContactForm contactForm)
		{
			dBContactFormManager.CreateAContactForm(contactForm);
		}

		public List<ContactForm> GetContactForms()
		{
			return dBContactFormManager.ReadAllContactForms();
		}

		public List<ContactForm> ReadAllContactForms()
		{
			return dBContactFormManager.ReadAllContactForms();
		}

		public void SendAContactForm(ContactForm contactForm)
		{
			dBContactFormManager.CreateAContactForm(contactForm);
		}

		public void UpdateContactForm(ContactForm contactForm)
		{
			dBContactFormManager.UpdateContactForm(contactForm);
		}
	}
}
