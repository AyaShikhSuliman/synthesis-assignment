using Logic.Classes.Address;
using Logic.Classes.ContactForms;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Properties.FakeDataManagers
{
    public class FakeDBContactFormManager : IDBContactFormManager, IWebsiteAdministratorContactFormManager
    {
        private List<ContactForm> contacts = new List<ContactForm>();

        public FakeDBContactFormManager()
        {
            ContactForm contact = new ContactForm(1, "Nick", "ni@gmail.com", "Nice?", "", Logic.Enums.ContactFormStatus.NotAnswered);
            contacts.Add(contact);
        }
        public List<ContactForm> ReadAllContactForms()
        {
            return contacts;
        }

        public void UpdateContactForm(ContactForm contactForm)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == contactForm.Id)
                {
                    contact.Answer = contactForm.Answer;
                }
            }
        }

        public void CreateAContactForm(ContactForm contactForm)
        {
            contacts.Add(contactForm);
        }

        public List<ContactForm> GetContactForms()
        {
            return contacts;
        }

        public void AnswerContactFormQuestion(ContactForm contactForm)
        {
            foreach (ContactForm contact in contacts)
            {
                if (contact.Id == contactForm.Id)
                {
                    contact.Answer = contactForm.Answer;
                    contact.ContactFormStatus = Logic.Enums.ContactFormStatus.Answered;

                }
            }
        }
    }
}
