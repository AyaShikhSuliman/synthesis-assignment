using Logic.Classes.Orders;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts.Customer
{
    public class Customer : Account
    {
        public Customer(int id, string name, string lastName, string emailAddress, int phoneNumber, Classes.Address.Address? address, string password, string saltPassword, List<Order>? orders) : base(id, name, lastName, emailAddress, phoneNumber, address, password, saltPassword, orders) { }
        public Customer(int id, string name, string lastName, string emailAddress, int phoneNumber, string password, string saltPassword) : base(id, name, lastName, emailAddress, phoneNumber, password, saltPassword) { }
        public Customer(int id, string emailAddress, string password, string saltPassword, List<Order>? orders) : base(id, emailAddress, password, saltPassword, orders) { }
        public Customer(string emailAddress, string password, string saltPassword) : base(emailAddress, password, saltPassword) { }
        public Customer() { }
    }
}
