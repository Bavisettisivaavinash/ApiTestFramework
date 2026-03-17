using ApiTestFramework.Models.Requests;
using ApiTestFramework.Models.Common;
using ApiTestFramework.Utilities;

namespace ApiTestFramework.TestData
{
    public static class BookingTestDataBuilder
    {
        public static CreateBookingRequest BuildCreateBookingRequest()
        {
            return new CreateBookingRequest
            {
                FirstName = RandomDataGenerator.GenerateRandomString(8),
                LastName = RandomDataGenerator.GenerateRandomString(10),
                TotalPrice = RandomDataGenerator.GenerateRandomNumber(100, 1000),
                DepositPaid = true,
                BookingDates = new BookingDates
                {
                    CheckIn = DateTime.Now.AddDays(7),
                    CheckOut = DateTime.Now.AddDays(14)
                },
                AdditionalNeeds = RandomDataGenerator.GenerateRandomString(15)
            };
        }
    }
}