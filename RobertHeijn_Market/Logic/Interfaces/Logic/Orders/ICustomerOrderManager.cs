using Logic.Classes.Orders;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Orders
{
    public interface ICustomerOrderManager
    {
		void PlaceAnOrder(Order order);
        void CreateCart(Order order, int customerId);
        int GetCartId(int customerId);
        Order GetCart(int customerId);
        List<PaymentMethod> GetPaymentMethods();
        void AddOrderTotalPrice(Order order);
    }
}
