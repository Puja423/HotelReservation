//using Microsoft.VisualBasic;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading;
//using System.Globalization;

//namespace HotelReservation
//{
//    public class HotelReservation
//    {

//        ArrayList hotelList = new ArrayList();
//        public bool AddHotel(Hotel newHotel)
//        {
//            hotelList.Add(newHotel);
//            return true;
//        }



//        public double FindRate(string startDateString, string endDateString)
//        {
//            double rate = 0;
//            try
//            {
//                CultureInfo provider = CultureInfo.InvariantCulture;
//                DateTime startDate = Convert.ToDateTime(startDateString);
//                DateTime endDate = Convert.ToDateTime(endDateString);
//                for (; startDate <= endDate; startDate = startDate.AddDays(1))
//                {
//                    rate = rate + RATE;
//                }
//            }
//            catch (Exception)
//            {
//                throw new HotelException(HotelException.ExceptionType.INVALID_DATE, "Invalid date entered");
//            }
//            return rate;
//        }
//        static void Main(string[] args)
//        {
           
//            Console.WriteLine("Welcome to the hotel Book SystemS");
            
//            while (true)
//            {
//                Console.WriteLine("/n1.Add a hotel /n2.Cheapest hotel /n3. Exit");
//                int option = Int32.Parse(Console.ReadLine());
//                switch (option)
//                {
//                    case 1:
//                        while (true)
//                        {
//                            Console.WriteLine("DO YOU WISH TO ADD NEW HOTEL(Y/N)");
//                            string choice;
//                            choice = Console.ReadLine();
//                            if (choice == "Y")
//                            {
//                                Console.WriteLine("Enter the name of the hotel ");
//                                string name = Console.ReadLine();
//                                Console.WriteLine("Enter the rate of the hotel");
//                                int rate = Int32.Parse(Console.ReadLine());
//                                Hotel hotel = new Hotel(name, rate);


//                                Console.WriteLine("Hotel" + name + "Added to the reservation system");
//                            }
//                            else
//                            {
//                                Console.WriteLine("thank you");
//                                break;
//                            }

//                        }

//                        break;
//                    case 2:

//                        try
//                        {
//                            Console.WriteLine("Enter start date of the stay in dd/MM/yyyy format");
//                            string start = Console.ReadLine();
//                            Console.WriteLine("Enter end day of the stay in dd/MM/yyyy format");
//                            string end = Console.ReadLine();
//                        }
//                        catch (Exception e)
//                        {
//                            Console.WriteLine("error");
//                        }

//                        Hotel Found = service.FindCheapHotel(startDate, endDate);
//                        Console.WriteLine(Found);
//                        break;

//                    case 3:
//                        Console.WriteLine("thank you for using application");

//                        break;


//                }

//            }
//        }
//    }
//}

