using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Classes.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBContactFormManager
	{
        List<ContactForm> ReadAllContactForms();
        void UpdateContactForm(ContactForm contactForm);
        void CreateAContactForm(ContactForm contactForm);
     
    }
}
