using Logic.Classes;
using Logic.Classes.Accounts.WebsiteAdminstrator;
using Logic.Classes.Orders;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBOrderManager
	{
		void UpdateOrder(Order order);
        void CreateAnOrder(Order order, int id);
        int ReadOrderId(int customerId);
		List<Order> ReadAllOrders(int customerId);
		Order ReadCart(int customerId);
		List<PaymentMethod> ReadAllPaymentMethods();
    }
}
