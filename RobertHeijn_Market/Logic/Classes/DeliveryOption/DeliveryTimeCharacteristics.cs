using Logic.Classes.DeliveryOption.DeliveryOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.DeliveryOption
{
    public class DeliveryTimeCharacteristics
    {
        public DeliveryTimeCharacteristics(int id, TimeOnly startTime, TimeOnly endTime, int slotPerHour, int orderPerSlot, DeliveryOptionNameManager deliveryOptionNameManager)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            SlotPerHour = slotPerHour;
            OrderPerSlot = orderPerSlot;
            DeliveryOptionNameManager = deliveryOptionNameManager;
        }

        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set;}
        public int SlotPerHour { get; set; }
        public int OrderPerSlot { get; set;}
        public DeliveryOptionNameManager DeliveryOptionNameManager { get; set; }
    }
}
