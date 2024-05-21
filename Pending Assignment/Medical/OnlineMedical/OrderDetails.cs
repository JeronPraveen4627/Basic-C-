using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public enum OrderStatus{Purchased,Cancelled};
    public class OrderDetails
    {
        // a.	OrderID (Auto increment - OID2001)
        // b.	UserID
        // c.	MedicineID
        // d.	MedicineCount
        // e.	TotalPrice
        // f.	OrderDate
        // g.	OrderStatus {Enum – Purchased, Cancelled}

        private static int s_orderID=2001;

        public string OrderID{get;}

        public string UserID{get;set;}
        public string MedicineID{get;set;}

        public int MedicineCount{get;set;}

        public double TotalPrice{get;set;}

        public DateTime OrderDate{get;set;}

        public OrderStatus OrderStatus{get;set;}

        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            OrderID="OID"+(++s_orderID);
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }
        public OrderDetails(string lines)
        {
            string[] Values=lines.Split(",");
            OrderID=Values[0];
            s_orderID=int.Parse(Values[0].Remove(0,3));  
            UserID=Values[1];
            MedicineID=Values[2];
            MedicineCount=int.Parse(Values[3]);
            TotalPrice=double.Parse(Values[4]);
            OrderDate=DateTime.ParseExact(Values[5],"dd/MM/yyyy",null);
            OrderStatus=Enum.Parse<OrderStatus>(Values[6]);
        }

    }
}