using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.DeliveryOption.TimeSlot;

namespace Logic.Classes.DeliveryOption
{
    public class DeliveyOptionDetails
    {
        public int Id { get; set; }
        public Location location { get; set; }
        public List<TimeSlot.TimeSlot> TimeSlots { get; set; }

        public DeliveyOptionDetails(int id, Location location, List<TimeSlot.TimeSlot> timeSlots)
        {
            Id = id;
            this.location = location;
            TimeSlots = timeSlots;
        }
    }
}
