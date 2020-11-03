using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace HotelReservation
{
	public class Hotel
	{

		private String hotelName;
		private int regularCustomerRate;
		private long totalRate;

		// parameterized constructor
		public Hotel(String hotelName, int regularCustomerRate)
		{
			this.hotelName = hotelName;
			this.regularCustomerRate = regularCustomerRate;
			this.totalRate = 0;
		}

		// getters and setters
		public String getHotelName()
		{
			return hotelName;
		}

		public void setHotelName(String hotelName)
		{
			this.hotelName = hotelName;
		}

		public int getRegularCustomerRate()
		{
			return regularCustomerRate;
		}

		public void setRegularCustomerRate(int rate)
		{
			this.regularCustomerRate = rate;
		}

		public long getTotalRate()
		{
			return totalRate;
		}

		public void setTotalRate(long rate)
		{
			this.totalRate = rate;
		}


	}
	public double FindRate(string startDateString, string endDateString)
	{
		double rate = 0;
		try
		{
			CultureInfo provider = CultureInfo.InvariantCulture;
			DateTime startDate = Convert.ToDateTime(startDateString);
			DateTime endDate = Convert.ToDateTime(endDateString);
			for (; startDate <= endDate; startDate = startDate.AddDays(1))
			{
				rate = rate + RATE;
			}
		}

	}
}	
