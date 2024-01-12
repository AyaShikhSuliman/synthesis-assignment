using Logic.Enums;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.DeliveryOption.DeliveryOption
{
    public class DeliveyOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeliveryTimeCharacteristics deliveryTimeCharacteristics { get; set; }
        public List<DeliveyOptionDetails> DeliveyOptionDetails { get; set; }

        public DeliveyOption(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public DeliveyOption(int id, string name, DeliveryTimeCharacteristics deliveryTimeCharacteristics, List<DeliveyOptionDetails> DeliveyOptionDetails)
        {
            Id = id;
            Name = name;
            this.deliveryTimeCharacteristics = deliveryTimeCharacteristics;
            this.DeliveyOptionDetails = DeliveyOptionDetails;
        }
    }
}
