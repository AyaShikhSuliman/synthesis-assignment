using Logic.Classes.Accounts.Customer;
using Logic.Classes.DeliveryOption;
using Logic.Classes.Products;
using Logic.Classes.ProductOrder;
using Logic.Enums;
using Logic.Interfaces.Logic;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.Delivery;

namespace Logic.Classes.Orders
{
    public class Order
	{
		public int Id { get; set; }
		public string DateAndTime { get; set; }
		public OrderDeliveryOption? OrderDeliveryOption { get; set; }//
		public OrderStatus? OrderStatus { get; set; }
		public double? TotalOrderPrice { get; set; }
		public PaymentMethod? PaymentMethod { get; set; }
		public OrderType OrderType { get; set; }
		public List<ProductOrder.ProductOrder> ProductOrder { get; set; }

		public Order() { }

        public Order(int id, string dateAndTime, OrderDeliveryOption? OrderDeliveryOption, OrderStatus? orderStatus, double? totalOrderPrice, PaymentMethod? paymentMethod, OrderType orderType, List<ProductOrder.ProductOrder> productOrder)
        {
            Id = id;
			DateAndTime = dateAndTime;
            this.OrderDeliveryOption = OrderDeliveryOption;
            TotalOrderPrice = totalOrderPrice;
            PaymentMethod = paymentMethod;
            OrderType = orderType;
            ProductOrder = productOrder;
        }

        public Order(int id, string dateAndTime, List<ProductOrder.ProductOrder> productOrders)
        {
            Id = id;
			DateAndTime = dateAndTime;
            ProductOrder = productOrders;
        }

        public Order(int id, OrderType OrderType, List<ProductOrder.ProductOrder> ProductOrder)
        {
            Id = id;
            this.OrderType = OrderType;
            this.ProductOrder = ProductOrder;
        }
    }
}
