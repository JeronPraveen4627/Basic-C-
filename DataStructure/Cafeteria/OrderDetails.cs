using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum OrderStatus{Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        // OrderID (Auto – OID1001)
        // UserID
        // OrderDate
        // TotalPrice
        // OrderStatus – (Default, Initiated, Ordered, Cancelled)

        private static int s_orderID=1001;

        public string OrderID{get;}

        public string UserID{get;set;}

        public DateTime OrderDate{get;set;}

        public double TotalPrice{get;set;}

        public OrderStatus OrderStatus{get;set;}

        public OrderDetails(string userID, DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            OrderID="OID"+(++s_orderID);
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
            
        }

    }
}