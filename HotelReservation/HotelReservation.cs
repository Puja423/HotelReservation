using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class HotelReservation
    {

        ArrayList hotelList = new ArrayList();
        public bool AddHotel(Hotel newHotel)
        {
            hotelList.Add(newHotel);
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hotel Book SystemS");
            HotelReservation service = new HotelReservation();
            Hotel Hotel1 = new Hotel("Lakewood", 110);
            Hotel Hotel2 = new Hotel("Bridgewood", 160);
            Hotel Hotel3 = new Hotel("Ridgewood", 220);
            service.AddHotel(Hotel1);
            service.AddHotel(Hotel2);
            service.AddHotel(Hotel3);

            while (true)
            {
                Console.WriteLine("DO YOU WISH TO ADD NEW HOTEL(Y/N)");
                string choice;
                choice = Console.ReadLine();
                if (choice == "Y")
                {
                    Console.WriteLine("Enter the name of the hotel ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the rate of the hotel");
                    int rate = Int32.Parse(Console.ReadLine());
                    Hotel hotel = new Hotel(name, rate);


                    Console.WriteLine("Hotel" + name + "Added to the reservation system");
                }
                else
                {
                    Console.WriteLine("thank you");
                    break;
                }


            }
        }
    }
}
