using System;

namespace BookingManager
{
    class BookingDO {

        public DateTime startTime { get; set; }
        public  DateTime endTime { get; set; }

        public BookingDO(DateTime startTime, DateTime endTime)
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
