using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ContactForms
{
	public class ContactForm
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string EmailAddress { get; set; }
		public string Question { get; set; }
		public string? Answer { get; set; }
		public ContactFormStatus ContactFormStatus { get; set; }

		public ContactForm(int id, string name, string emailAddress, string question, string? answer, ContactFormStatus contactFormStatus)
		{
			Id = id;
			Name = name;
			EmailAddress = emailAddress;
			Question = question;
			Answer = answer;
			ContactFormStatus = contactFormStatus;
		}
	}
}
