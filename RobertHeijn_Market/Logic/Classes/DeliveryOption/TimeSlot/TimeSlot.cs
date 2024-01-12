using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.DeliveryOption.TimeSlot
{
    public class TimeSlot
    {
        public TimeSlot(int id, TimeOnly startTime, TimeOnly endTime)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
        }

        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
