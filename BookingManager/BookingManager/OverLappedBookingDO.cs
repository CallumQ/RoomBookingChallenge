namespace BookingManager
{
    /// <summary>
    /// The Domain Object for the underlying overlapped booking object
    /// This is used to pair together two conflicting dates
    /// </summary>
    class OverLappedBookingDO {

        public BookingDO firstDate;
        public BookingDO secondDate;

        public OverLappedBookingDO(BookingDO firstDate, BookingDO secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public override string ToString()
        {
            return "Booking : "+ firstDate.ToString() + " overlaps with : " + secondDate.ToString();
        }
    }

    
}
