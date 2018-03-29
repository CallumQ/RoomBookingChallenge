using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingManagerTest
{
    [TestFixture]
    class BookingManagerTest
    {
        [SetUp]
        protected void SetUp(){

        }

        /// <summary>
        /// should return a value if two bookings share the exact same start and end time
        /// </summary>
        [Test]
        public void testReturnOverLapForSameDate() {

        }

        /// <summary>
        /// Test should pass when one booking has the same end time as another's start time
        /// </summary>
        [Test]
        public void testReturnNoOverlapForEndAndStartDate(){

        }

        /// <summary>
        ///  Test should pass when one booking has the same start time as another's end time
        /// </summary>
        [Test]
        public void testReturnNoOverlapForStartAndEndtDate(){

        }

        /// <summary>
        /// Test should throw an exception when the booking read from the file is malformed 
        /// </summary>
        [Test]
        public void testReadingMalformedDateFromFileThrowsException(){

        }

        /// <summary>
        /// Test should throw an exception when the file it is looking for does not exist
        /// </summary>
        [Test]
        public void testReadingFromNonexistantFileThrowsException() {

        }

    }
}
