using Logic.Interfaces.Data;
using Logic.Interfaces.Logic.DeliveryOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.DeliveryOption.DeliveryOption
{
    public class DeliveryOptionNameManager: IDeliveryOptionNameManager
    {
        private IDBDeliveryOptionNameManager dBDeliveryOptionManager;

        public DeliveryOptionNameManager(IDBDeliveryOptionNameManager dBDeliveryOptionManager)
        {
            this.dBDeliveryOptionManager = dBDeliveryOptionManager;
        }

        public List<DeliveyOption> GetDeliveryOptions()
        {
            return dBDeliveryOptionManager.ReadAllDeliveryOptions();
        }

        public int GetDeliveOptionId(string deliveryOptionName)
        {
            return dBDeliveryOptionManager.ReadDeliveOptionId(deliveryOptionName);
        }
    }
}
