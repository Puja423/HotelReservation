using System;

namespace HotelReservation
{
	class Program
	{
		public class HotelReservation
		{

			private ArrayList<Hotel> Hotel = new ArrayList<Hotel>();

			public bool addHotel(Hotel newHotel)
			{
				Hotel.add(newHotel);
				return true;
			}

			// method to add a hotel

			public Hotel findCheapestHotel(string startDate, string endDate)
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

			// method to find cheapest hotel with in a date range

			public static void main(String[] args)
			{
				

				Console.WriteLine("Welcome to Hotel Reservation Program!");
				HotelReservation service = new HotelReservation();
				Hotel hotel1 = new Hotel("Lakewood", 110);
				Hotel hotel2 = new Hotel("Bridgewood", 160);
				Hotel hotel3 = new Hotel("Ridgewood", 220);
				service.addHotel(hotel1);
				service.addHotel(hotel2);
				service.addHotel(hotel3);
				while (true) {
					Console.WriteLine("\n1.Add a Hotel \n2.Find the cheapest Hotel \n3.Exit \nEnter your choice: ");
					int option = Console.ReadLine();
					switch (option) {
                        case 1:
							
							while (true) {
								Console.WriteLine("Do you wish to add a new Hotel to the System?(y/n)");
								String choice = Console.ReadLine();
								if (choice == "y")) {
									Console.WriteLine("Enter the Name of the Hotel: ");
									String name = Console.ReadLine();
									Console.WriteLine("Enter the rates of the Hotel for a Regular Customer: ");
									
									Hotel newHotel = new Hotel(name, rate);
									service.addHotel(newHotel);
									Console.WriteLine("Hotel " + name + " added to the Hotel Reservation System!\n");

								else {
										Console.WriteLine("Thankyou!");
										break;
									}
								}
								break;
							}
								case 2:
							try
							{
								Console.WriteLine("Enter start date of the stay :");
								String start = Console.ReadLine();

								Console.WriteLine("Enter end date of the stay:");
								String end = Console.ReadLine();

							}
							catch (Exception e)
							{
								Console.WriteLine("error");
							}

							Hotel found = service.findCheapestHotel(start, end);
							Console.WriteLine(found);
							break;

						case 3:
							Console.WriteLine("Thankyou for using the application!");

							break;

					}

				}
			}


		}
	}
}
