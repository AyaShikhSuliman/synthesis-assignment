using Logic.Classes.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.ContactForms
{
    public interface ICustomersContactFormManager
    {
        void SendAContactForm(ContactForm contactForm);
        List<ContactForm> ReadAllContactForms();
        void UpdateContactForm(ContactForm contactForm);
        void CreateAContactForm(ContactForm contactForm);
    }
}
