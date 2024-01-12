using Azure;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.DeliveryOption.TimeSlot
{
    public class TimeSlotManager : ITimeSlotManager
    {
        private IDBDeliveryOptionCharacteristicsManager DeliveryOptionCharacteristicsManager;
        private IDBTimeSlotManager dBTimeSlotManager;

        public TimeSlotManager(IDBTimeSlotManager dBTimeSlotManager, IDBDeliveryOptionCharacteristicsManager DeliveryOptionCharacteristicsManager)
        {
            this.dBTimeSlotManager = dBTimeSlotManager;
            this.DeliveryOptionCharacteristicsManager = DeliveryOptionCharacteristicsManager;
        }

        public int CalculateNumberOfHours(int deliveryOptionId)
        {            
            TimeOnly dateFrom = DeliveryOptionCharacteristicsManager.ReadStartTime(deliveryOptionId);
            TimeOnly dateTo = DeliveryOptionCharacteristicsManager.ReadEndTime(deliveryOptionId);
            int numberofhours = Convert.ToInt32( (dateFrom - dateTo).TotalHours);

            return numberofhours;
        }


        public List<string> CalculateTimeSlots(int deliveryOptionId)
        {
            int slotsPerHour = DeliveryOptionCharacteristicsManager.ReadSlotsPerHour(deliveryOptionId);
            int minToAdd = 60 / slotsPerHour;
            int totalTime = CalculateNumberOfHours(deliveryOptionId);
            int totalSlots = slotsPerHour * totalTime;

            TimeOnly currentTime = DeliveryOptionCharacteristicsManager.ReadStartTime(deliveryOptionId);

            List<string> timeslots = new List<string>();

            for (int i = 0; i <= totalSlots; i++)
            {
                timeslots.Add($"{currentTime} - {currentTime.AddMinutes(minToAdd)}");

                currentTime = currentTime.AddMinutes(minToAdd);
            }

            return timeslots;
        }

        public List<string> GetPickUpAvailableTimeSlots(DateOnly chosenDate, int deliveryOptionId, int locationId)
        {
            List<string> timeslots = CalculateTimeSlots(deliveryOptionId);

            DateOnly dateOnly = chosenDate;
            DateTime testDateTime = dateOnly.ToDateTime(TimeOnly.Parse("00:00:00"));

            foreach (string timeslotFromDatabase in dBTimeSlotManager.ReadAllReservedPickUpSlots(testDateTime, deliveryOptionId, locationId))
            {
                foreach (string timeslot in timeslots)
                {
                    if (timeslotFromDatabase == timeslot)
                    {
                        timeslots.Remove(timeslotFromDatabase);
                    }
                }
            }

            return timeslots;
        }

        public List<string> GetHomeAvailableTimeSlots(DateOnly chosenDate, int deliveryOptionId)
        {
            List<string> timeslots = CalculateTimeSlots(deliveryOptionId);

            DateOnly dateOnly = chosenDate;
            DateTime testDateTime = dateOnly.ToDateTime(TimeOnly.Parse("00:00:00"));

            foreach(string timeslotFromDatabase in dBTimeSlotManager.ReadAllReservedHomeTimeSlots(testDateTime, deliveryOptionId)) 
            {
                foreach(string timeslot in timeslots)
                {
                    if(timeslotFromDatabase == timeslot)
                    {
                        timeslots.Remove(timeslotFromDatabase);
                    }
                }
            }
            
            return timeslots;
        }
    }
}
