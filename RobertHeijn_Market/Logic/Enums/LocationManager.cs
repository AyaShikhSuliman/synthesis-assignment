using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Enums
{
    public class LocationManager: ILocationManager
    {
        private IDBLocationManager dBLocationManager;

        public LocationManager(IDBLocationManager dBLocationManager)
        {
            this.dBLocationManager = dBLocationManager;
        }

        public List<Location> GetAllLocations(int deliveryOptionId)
        {
            return dBLocationManager.ReadAllLocations(deliveryOptionId);
        }

        public int GetLocationId(string locationName)
        {
            return dBLocationManager.ReadLocationId(locationName);
        }

    }
}
