using Azure;
using Logic.Classes.Orders;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Logic.Classes.Accounts
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public Classes.Address.Address Address { get; set; }
        public string Password { get; set; }
        public List<Order>? Orders { get; set; }
        public string SaltPassword { get; set; }

        public Account(int id, string emailAddress, string password, string saltPassword, List<Order>? Orders)
        {
            Id = id;
            EmailAddress = emailAddress;
            Password = password;
            SaltPassword = saltPassword;
            this.Orders = Orders;
        }

        public Account(string emailAddress, string password, string saltPassword)
        {
            EmailAddress = emailAddress;
            Password = password;
            SaltPassword = saltPassword;
        }


        public Account(int id, string name, string lastName, string emailAddress, int phoneNumber, Classes.Address.Address address, string password, string saltPassword, List<Order>? orders)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Address = address;
            Password = password;
            SaltPassword = saltPassword;
            Orders = orders;
        }

        public Account(int id, string name, string lastName, string emailAddress, int phoneNumber, string password, string saltPassword)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Password = password;
            SaltPassword = saltPassword;
        }

        public Account(int id, string name, string lastName, int age, Gender gender, string emailAddress, int phoneNumber, Classes.Address.Address address, string password)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            Gender = gender;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Address = address;
            Password = password;
        }

        public Account() { }
    }
}
