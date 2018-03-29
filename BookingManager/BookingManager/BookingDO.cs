using System;

namespace BookingManager
{
    /// <summary>
    /// The underlying Domain Object for a Booking
    /// </summary>
    class BookingDO {

        public DateTime startTime { get; set; }
        public  DateTime endTime { get; set; }

        public BookingDO(DateTime startTime, DateTime endTime)
        {
            //If the startTime of a booking is after its endTime then it is not a valid booking
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
