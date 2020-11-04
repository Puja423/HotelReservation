using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    class HotelException
    {
        public HotelException(ExceptionType iNVALID_HOTEL_TYPE, string v)
        {
        }

        public enum ExceptionType
        {
            INVALID_DATE,
            INVALID_CUSTOMER_TYPE,
            INVALID_HOTEL_TYPE
        }
    }
}
