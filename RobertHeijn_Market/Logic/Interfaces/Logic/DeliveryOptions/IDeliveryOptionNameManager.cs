using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.DeliveryOption;
using Logic.Classes.DeliveryOption.DeliveryOption;

namespace Logic.Interfaces.Logic.DeliveryOptions
{
    public interface IDeliveryOptionNameManager
    {
        List<DeliveyOption> GetDeliveryOptions();
        int GetDeliveOptionId(string deliveryOptionName);
    }
}
