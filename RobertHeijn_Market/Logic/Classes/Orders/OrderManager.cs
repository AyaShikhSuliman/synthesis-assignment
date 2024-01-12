using Logic.Classes.Accounts.Customer;
using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Orders
{
    public class OrderManager : ICustomerOrderManager, IWebsiteAdministratorOrderManager
    {
        private IDBOrderManager dBOrderManager;
        private IDBCustomerManager dBCustomerManager;

        public OrderManager(IDBOrderManager dBOrderManager, IDBCustomerManager dBCustomerManager)
        {
            this.dBOrderManager = dBOrderManager;
            this.dBCustomerManager = dBCustomerManager;
        }

        public List<Order> GetOrders(int customerId)
        {
           return dBOrderManager.ReadAllOrders(customerId);
        }

        public Order GetCart(int customerId)
        {
            return dBOrderManager.ReadCart(customerId);
        }

        public void UpdateOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }

        public void EditOrder(Order order)
        {
            dBOrderManager.UpdateOrder(order);
        }

        public void AddOrderTotalPrice(Order order)
        {
            EditOrder(order);
        }

        public void PlaceAnOrder(Order order)
        {
            order.OrderType = OrderType.Order;
            order.OrderStatus = OrderStatus.inPreparation;
            EditOrder(order);
        }

        public void CreateCart(Order order, int customerId)
        {
            order.OrderType = Enums.OrderType.Cart;
            dBOrderManager.CreateAnOrder(order, customerId);
        }

        public int GetCartId(int customerId)
        {
            Order order = GetCart(customerId);
            return order.Id;

        }

        public List<PaymentMethod> GetPaymentMethods()
        {
            return dBOrderManager.ReadAllPaymentMethods();
        }
    }
}
