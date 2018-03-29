namespace BookingManager
{
    class OverLappedbooking {
        public BookingDO firstDate;
        public BookingDO secondDate;

        public OverLappedbooking(BookingDO firstDate, BookingDO secondDate)
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
