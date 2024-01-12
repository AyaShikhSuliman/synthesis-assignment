using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface ITimeSlotManager
    {
        List<string> GetPickUpAvailableTimeSlots(DateOnly chosenDate, int deliveryOptionId, int locationId);
        List<string> GetHomeAvailableTimeSlots(DateOnly chosenDate, int deliveryOptionId);
    }
}
