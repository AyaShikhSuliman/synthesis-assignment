using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts.WebsiteAdminstrator
{
    public class WebsiteAdministrator: Account
    {
		//public int Id { get; set; }
  //      public string Name { get; set; }
  //      public string LastName { get; set; }
  //      public int Age { get; set; }
  //      public Gender Gender { get; set; }
  //      public string EmailAddress { get; set; }
  //      public int PhoneNumber { get; set; }
  //      public Address.Address Address { get; set; }
  //      public string Password { get; set; }

		public WebsiteAdministrator(int id, string name, string lastName, int age, Gender gender, string emailAddress, int phoneNumber, Classes.Address.Address address, string password) 
			: base(id, name, lastName, age, gender, emailAddress, phoneNumber, address, password)
		{
			//Id = id;
			//Name = name;
			//LastName = lastName;
			//Age = age;
			//Gender = gender;
			//EmailAddress = emailAddress;
			//PhoneNumber = phoneNumber;
			//Address = address;
			//Password = password;
		}
	}
}
