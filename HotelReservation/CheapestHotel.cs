using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
   public class CheapestHotel
    {
        public void FindCheapHotel(string startDate, string endDate)
        {
            HotelName hotelName = HotelName.Lakewood;
            Hotel lakewood = new Hotel(hotelName);
            double rateLakewood = lakewood.FindRate(startDate, endDate);
            hotelName = HotelName.Bridgewood;
            Hotel bridgewood = new Hotel(hotelName);
            double rateBridgewood = bridgewood.FindRate(startDate, endDate);
            hotelName = HotelName.Ridgewood;
            Hotel ridgewood = new Hotel(hotelName);
            double rateRidgewood = ridgewood.FindRate(startDate, endDate);
            if (rateLakewood < rateBridgewood && rateLakewood < rateRidgewood)
            {
                hotelName = HotelName.Lakewood;
                Console.WriteLine("hotel" + hotelName + " Cost: " + rateLakewood);
            }
            if (rateBridgewood < rateLakewood && rateBridgewood < rateRidgewood)
            {
                hotelName = HotelName.Bridgewood;
                Console.WriteLine("hotel " + hotelName + " Cost: " + rateBridgewood);
            }
            if (rateRidgewood < rateLakewood && rateRidgewood < rateBridgewood)
            {
                hotelName = HotelName.Ridgewood;
                Console.WriteLine("Hote" + hotelName + "Cost:" + rateRidgewood);
            }
        }
    }
}
