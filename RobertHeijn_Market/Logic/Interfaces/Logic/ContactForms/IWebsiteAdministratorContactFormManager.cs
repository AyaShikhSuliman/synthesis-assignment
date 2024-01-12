using Logic.Classes.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.ContactForms
{
	public interface IWebsiteAdministratorContactFormManager
	{
		List<ContactForm> GetContactForms();
		void AnswerContactFormQuestion(ContactForm contactForm);
	}
}
