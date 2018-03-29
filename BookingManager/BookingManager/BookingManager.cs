using System;
using System.Collections.Generic;
using System.IO;

namespace BookingManager
{
    class BookingManager
    {

        public List<Booking> bookingList = new List<Booking>();
        static void Main(string[] args)
        {

            BookingManager bookingManager = new BookingManager();
            string currentLine;
            using (StreamReader reader = new StreamReader(@"C:\Users\QuigleyCallumR\helloworld1.txt"))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    string[] rawDates = currentLine.Split(" , ");

                    bookingManager.bookingList.Add(new Booking(DateTime.Parse(rawDates[0]), DateTime.Parse(rawDates[1])));

                }
            }

            foreach (Booking booking in bookingManager.bookingList) {
                foreach (Booking comparedBooking in bookingManager.bookingList) {
                    
                    if ((booking.startTime < comparedBooking.endTime) && (comparedBooking.startTime < booking.endTime) && (!booking.Equals(comparedBooking))) {
                        Console.WriteLine("booking overlap");
                    }

                }
            }

            

            Console.ReadKey();

        }
    }


    class Booking {

        public DateTime startTime { get; set; }
        public  DateTime endTime { get; set; }

        public Booking(DateTime startTime, DateTime endTime)
        {
            if (startTime < endTime)
            {

                this.startTime = startTime;
                this.endTime = endTime;
            }

            else {
                throw new Exception("Start time must be before end time");

            }
        }

        public override string ToString()
        {
            return "Start Time : " + startTime + " End Time : " + endTime;
        }
    }
}
