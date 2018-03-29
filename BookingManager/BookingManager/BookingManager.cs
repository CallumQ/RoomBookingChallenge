using System;
using System.Collections.Generic;
using System.IO;

namespace BookingManager
{
    class BookingManager
    {

        public List<BookingDO> bookingList = new List<BookingDO>();
        static void Main(string[] args)
        {
             
            BookingManager bookingManager = new BookingManager();
            List<OverLappedbooking> overlappedBookings = new List<OverLappedbooking>();

            bookingManager.bookingList = bookingManager.GetBookings();

            bookingManager.DisplayConflictedItems(bookingManager.GetConflictedBookings());

            Console.ReadKey();

        }

        public List<BookingDO> GetBookings() {
            List<BookingDO> bookings = new List<BookingDO>();
            string currentLine;

            using (StreamReader reader = new StreamReader(@"C:\Users\QuigleyCallumR\helloworld1.txt"))
            {
                while ((currentLine = reader.ReadLine()) != null)
                {
                    string[] rawDates = currentLine.Split(" , ");

                    bookings.Add(new BookingDO(DateTime.Parse(rawDates[0]), DateTime.Parse(rawDates[1])));

                }
            }

            return bookings;

        }

        public List<OverLappedbooking> GetConflictedBookings() {

            List<OverLappedbooking> conflictedBookings = new List<OverLappedbooking>();

            foreach (BookingDO booking in bookingList)
            {
                foreach (BookingDO comparedBooking in bookingList)
                {

                    if ((booking.startTime < comparedBooking.endTime) && (comparedBooking.startTime < booking.endTime) && (!booking.Equals(comparedBooking)))
                    {
                        conflictedBookings.Add(new OverLappedbooking(booking, comparedBooking));
                    }

                }
            }

            return conflictedBookings;
        }

        public void DisplayConflictedItems(List<OverLappedbooking> conflictedBookings) {
            foreach (OverLappedbooking conflictedBooking in conflictedBookings) {
                Console.WriteLine(conflictedBooking.ToString());
            }
        }
    }

    
}
