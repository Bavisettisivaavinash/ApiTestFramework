namespace ApiTestFramework.Models.Responses
{
    public class CreateBookingResponse
    {
        public int BookingId { get; set; }
        public BookingResponse Booking { get; set; }
    }
}