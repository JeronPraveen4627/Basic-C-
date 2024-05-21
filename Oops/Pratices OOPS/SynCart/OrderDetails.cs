using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCart
{   
    //Enum declaration
    public  enum OrderStatus{Default, Ordered, Cancelled}
    public class OrderDetails
    {

        private static int s_orderedID=1001;
        /*Properties: 
            OrderID (Auto Increment – OID1001)
            CustomerID
            ProductID
            TotalPrice 
            PurchaseDate
            Quantity
            OrderStatus – (Enum- Default, Ordered, Cancelled)*/
            public string OrderedID{get;}
            public string CustomerID{get; set;}

            public string ProductID{get; set;}

            public double TotalPrice{get; set;}

            public DateTime Date{get; set;}

            public int Quantity{get; set;}

            public OrderStatus OrderedStatus{get; set;}

            public OrderDetails(string customerID,string productID,double totalPrice,DateTime date,int quantity,OrderStatus orderStatus)
            {
                s_orderedID++;
                OrderedID="OID"+s_orderedID;
                CustomerID=customerID;
                ProductID=productID;
                TotalPrice=totalPrice;
                Date=date;
                Quantity=quantity;
                OrderedStatus=orderStatus;
            }
            
    }
}