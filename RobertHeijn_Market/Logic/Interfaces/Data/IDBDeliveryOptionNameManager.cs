using Logic.Classes.DeliveryOption.DeliveryOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
    public interface IDBDeliveryOptionNameManager
    {
        List<DeliveyOption> ReadAllDeliveryOptions();
        int ReadDeliveOptionId(string deliveryOptionName);
    }
}
