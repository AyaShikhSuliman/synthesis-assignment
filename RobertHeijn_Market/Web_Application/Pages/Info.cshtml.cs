using Data;
using Logic.Classes.Address;
using Logic.Classes.DeliveryOption.DeliveryOption;
using Logic.Classes.Orders;
using Logic.Enums;
using Logic.Interfaces.Logic.DeliveryOptions;
using Logic.Interfaces.Logic.Orders;
using Logic.Interfaces.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Classes.DeliveryOption;
using Logic.Classes.DeliveryOption.TimeSlot;

namespace Web_Application.Pages
{
    public class InfoModel : PageModel
    {
        [BindProperty]
        public Address Address { get; set; }
        [BindProperty]
        public Order order { get; set; }
        [BindProperty]
        public List<Country> countries { get; set; }
        [BindProperty]
        public List<PaymentMethod> paymentMethods { get; set; }
        [BindProperty]
        public List<DeliveyOption> deliveyOptions { get; set; }
        [BindProperty]
        public List<Location>? Locations { get; set; }
        public int DeliveryOptionId { get; set; }
        public int CustomerID { get; set; }
        [BindProperty]
        public List<string> TimeSlots { get; set; }
        [BindProperty]
        public string ChosenDeliveryOption { get; set; }
        [BindProperty]
        public string check { get; set; }
        [BindProperty]
        public string? chosenDate { get; set; }
        [BindProperty]
        public Location? locationName { get; set; }

        private ICustomerAddressManager customerAddressManager = new AddressManager(new DBAdressManager());
        private ICustomerOrderManager customerOrderManager = new OrderManager(new DBOrderManager(), new DBCustomerManager());
        private IDeliveryOptionNameManager deliveryOptionNameManager = new DeliveryOptionNameManager(new DBDeliveryOptionNameManager());
        private ILocationManager locationManager = new LocationManager(new DBLocationManager());
        private ITimeSlotManager timeSlotManager = new TimeSlotManager(new DBTimeSlotManager(), new DBDeliveyOptionCharacteristics());

        public void OnGet()
        {
            try
            {
                CustomerID = HttpContext.Session.GetInt32("CustomerID").Value;
                countries = customerAddressManager.GetAllCountries();
                paymentMethods = customerOrderManager.GetPaymentMethods();
                deliveyOptions = deliveryOptionNameManager.GetDeliveryOptions();
                Locations = locationManager.GetAllLocations(DeliveryOptionId);
                if (DeliveryOptionId == 1)
                {
                    if (chosenDate != null)
                    {
                        DateOnly dateOnly = DateOnly.Parse(chosenDate);

                        TimeSlots = timeSlotManager.GetHomeAvailableTimeSlots(dateOnly, DeliveryOptionId);
                    }
                }
                else if (DeliveryOptionId == 2)
                {
                    if (locationName != null)
                    {
                        int locationId = locationManager.GetLocationId(locationName.ToString());

                        if (chosenDate != null)
                        {
                            DateOnly dateOnly = DateOnly.Parse(chosenDate);

                            timeSlotManager.GetPickUpAvailableTimeSlots(dateOnly, DeliveryOptionId, locationId);
                        }

                    }
                }
            }
            catch
            {
                Response.Redirect("/LogIn");

            }

        }

        public void OnPost()
        {
            CustomerID = HttpContext.Session.GetInt32("CustomerID").Value;

            Address address = new Address(0, Address.StreetName, Address.HouseNumber, Address.Postcode, Address.Country);
            customerAddressManager.AddAddressToCustomer(address, CustomerID);
            order = customerOrderManager.GetCart(CustomerID);


        }

        public void OnPostOrder()
        {
            HttpContext.Session.SetString("option", ChosenDeliveryOption);
            DeliveryOptionId = deliveryOptionNameManager.GetDeliveOptionId(ChosenDeliveryOption);

            check = HttpContext.Session.GetString("option");
            OnGet();
        }
    }
}
