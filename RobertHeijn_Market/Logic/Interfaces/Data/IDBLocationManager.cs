using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IDBLocationManager
    {
        List<Location> ReadAllLocations(int deliveryOptionId);
        int ReadLocationId(string locationName);
    }
}
