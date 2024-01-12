using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
    public interface ILocationManager
    {
        List<Location> GetAllLocations(int deliveryOptionId);
        int GetLocationId(string locationName);
    }
}
