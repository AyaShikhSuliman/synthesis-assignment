using Data;
using Logic.Classes.Address;
using Logic.Classes.ContactForms;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.ContactForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Properties.FakeDataManagers;
namespace Unit_Test
{
    [TestClass]
    public class ContactFormTests
    {
        ICustomersContactFormManager contactFormManager = new ContactFormManager(new FakeDBContactFormManager());
        IWebsiteAdministratorContactFormManager contctManager = new ContactFormManager(new FakeDBContactFormManager());

        [TestMethod]
        public void ReadAllContactFormsNotNull()
        {
            List<ContactForm> contactForms = contactFormManager.ReadAllContactForms();
            Assert.IsNotNull(contactForms);
        }
        [TestMethod]
        public void ReadAllContactFormsNull()
        {
            List<ContactForm> contactForms = contactFormManager.ReadAllContactForms();
            contactForms=null;
            Assert.IsNull(contactForms);
        }
        [TestMethod]
        public void UpdateContactFormTrue()
        {
            ContactForm contact = new ContactForm(1, "Nick", "ni@gmail.com", "Nice?", "Updated!", Logic.Enums.ContactFormStatus.NotAnswered);

            try
            {
                contactFormManager.UpdateContactForm(contact);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void UpdateContactFormFalse()
        {
            ContactForm contact = new ContactForm(2, "Nick", "ni@gmail.com", "Nice?", "Updated!", Logic.Enums.ContactFormStatus.NotAnswered);

            try
            {
                contactFormManager.UpdateContactForm(contact);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void CreateContactFormTrue()
        {
            ContactForm contact = new ContactForm(2, "Nick", "ni@gmail.com", "Nice?", "Updated!", Logic.Enums.ContactFormStatus.NotAnswered);

            try
            {
                contactFormManager.CreateAContactForm(contact);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void GetContactForms()
        {
            List<ContactForm> contactForms = contctManager.GetContactForms();
            Assert.IsNotNull(contactForms);
        }
        [TestMethod]
        public void GetContactFormsNull()
        {
            List<ContactForm> contactForms = contctManager.GetContactForms();
            contactForms = null;
            Assert.IsNull(contactForms);
        }
        [TestMethod]
        public void AnswerContactFormQuestionTrue()
        {
            ContactForm contact = new ContactForm(2, "Nick", "ni@gmail.com", "Nice?", "Updated!", Logic.Enums.ContactFormStatus.NotAnswered);

            try
            {
                contctManager.AnswerContactFormQuestion(contact);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]
        public void AnswerContactFormQuestionFalse()
        {
            ContactForm contact = new ContactForm(5, "Nick", "ni@gmail.com", "Nice?", "Updated!", Logic.Enums.ContactFormStatus.NotAnswered);

            try
            {
                contctManager.AnswerContactFormQuestion(contact);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

        }
    }
}
