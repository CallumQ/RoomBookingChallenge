using System;
using System.Collections.Generic;

namespace BookingManager
{
    class BookingManager
    {

        private List<Booking> bookingList = new List<Booking>();
        static void Main(string[] args)
        {
            //started dev @ 12:10
            



        }
    }


    class Booking {

        private DateTime startTime;
        private DateTime endTime;

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
    }
}
