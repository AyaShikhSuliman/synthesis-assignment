using Logic.Classes.DeliveryOption.TimeSlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IDBTimeSlotManager
    {
        List<string> ReadAllReservedHomeTimeSlots(DateTime dateTime, int deliveryOptionId);
        List<string> ReadAllReservedPickUpSlots(DateTime dateTime, int deliveryOptionId, int locationId);
    }
}
