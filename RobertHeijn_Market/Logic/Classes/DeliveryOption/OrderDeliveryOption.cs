using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Delivery
{
    public class OrderDeliveryOption
    {
        public OrderDeliveryOption(int id, int orderId)
        {
            Id = id;
            OrderId = orderId;
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
    }
}
