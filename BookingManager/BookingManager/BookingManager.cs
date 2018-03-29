using System;
using System.Collections.Generic;
using System.IO;

namespace BookingManager
{
    /// <summary>
    /// BookingManager centralises the bookings logged in the system
    /// </summary>
    class BookingManager
    {
        public List<BookingDO> bookingList = new List<BookingDO>();


        static void Main(string[] args)
        {
             
            BookingManager bookingManager = new BookingManager();
            List<OverLappedBookingDO> overlappedBookings = new List<OverLappedBookingDO>();

            bookingManager.bookingList = bookingManager.GetBookings();

            //Get the conflicted bookings and then log them to the console 
            bookingManager.DisplayConflictedItems(bookingManager.GetConflictedBookings());

            Console.ReadKey();

        }

        /// <summary>
        /// Reads the bookings from a file
        /// </summary>
        /// <returns>a list of booking objects</returns>
        public List<BookingDO> GetBookings() {

            List<BookingDO> bookings = new List<BookingDO>();
            string currentLine;

            try
            {
                using (StreamReader reader = new StreamReader("bookings.txt"))
                {
                    while ((currentLine = reader.ReadLine()) != null)
                    {

                        //Splits the line in the booking file on " ' "
                        //example booking line: 27/03/2018 04:30:00 , 27/03/2018 05:00:00
                        string[] rawDates = currentLine.Split(" , ");

                        bookings.Add(new BookingDO(DateTime.Parse(rawDates[0]), DateTime.Parse(rawDates[1])));

                    }
                }
            }

            catch (FileNotFoundException e ) {
                Console.WriteLine(e);
            }

            return bookings;

        }

        /// <summary>
        /// takes the current booking list and checks for scheduling conflicts
        /// </summary>
        /// <returns>A list of conflicted bookings</returns>
        public List<OverLappedBookingDO> GetConflictedBookings() {

            List<OverLappedBookingDO> conflictedBookings = new List<OverLappedBookingDO>();

            foreach (BookingDO booking in bookingList)
            {
                foreach (BookingDO comparedBooking in bookingList)
                {

                    if ((booking.startTime < comparedBooking.endTime) && (comparedBooking.startTime < booking.endTime) && (!booking.Equals(comparedBooking)))
                    {
                        conflictedBookings.Add(new OverLappedBookingDO(booking, comparedBooking));
                    }

                }
            }

            return conflictedBookings;
        }
        /// <summary>
        /// Displays the overlapped / conflicted bookings
        /// </summary>
        /// <param name="conflictedBookings">A list of overlapped booking objects</param>
        public void DisplayConflictedItems(List<OverLappedBookingDO> conflictedBookings) {

            foreach (OverLappedBookingDO conflictedBooking in conflictedBookings) {
                Console.WriteLine(conflictedBooking.ToString());
            }
        }
    }

    
}
