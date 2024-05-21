using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public enum BookingStatus{Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;
        public string BookingID{get;}
        public string CustomerID{get;set;}

        public double TotalPrice{get;set;}

        public DateTime DateOfBooking{get;set;}

        public BookingStatus BookingStatus{get;set;}

        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID="BID"+(++s_bookingID);
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }

        public void ShowBookingDetails()
        {
            
        }

    }
}