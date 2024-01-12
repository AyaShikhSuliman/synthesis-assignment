using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IDBDeliveryOptionCharacteristicsManager
    {
        int ReadSlotsPerHour(int deliveryOptionId);
        TimeOnly ReadStartTime(int deliveryOptionId);
        TimeOnly ReadEndTime(int deliveryOptionId);
    }
}
