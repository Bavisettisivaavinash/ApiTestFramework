using ApiTestFramework.Models.Common;

namespace ApiTestFramework.Models.Requests
{
    public class CreateBookingRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalPrice { get; set; }
        public bool DepositPaid { get; set; }
        public BookingDates BookingDates { get; set; }
        public string AdditionalNeeds { get; set; }
    }
}