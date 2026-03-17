using ApiTestFramework.Models.Common;

namespace ApiTestFramework.Models.Responses
{
    public class BookingResponse
    {
        public int BookingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TotalPrice { get; set; }
        public bool DepositPaid { get; set; }
        public BookingDates BookingDates { get; set; }
        public string AdditionalNeeds { get; set; }
    }
}