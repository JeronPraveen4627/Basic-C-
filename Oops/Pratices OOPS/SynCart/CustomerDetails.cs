using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynCart
{
    public class CustomerDetails
    {
        /*
        •	CustomerID (Auto Increment -CID1000)
        •	Name
        •	City
        •	MobileNumber
        •	WalletBalance
        •	EmailID*/

        //field 
        private static int s_customerID=1000;
        //Properties
        public string CustomerID{get;}
        public string CustomerName{get; set;}

        public string CustomerCity{get; set;}

        public long PhoneNumber{get; set;}

        public double WalletBalance{get; set;}

        public string EmailID{get; set;}


        public CustomerDetails(string customerName,string customerCity,long phoneNumber,string emailID,double walletBalance)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            CustomerName=customerName;
            CustomerCity=customerCity;
            PhoneNumber=phoneNumber;
            WalletBalance=walletBalance;
            EmailID=emailID;
        }

        public double walletBalance(double reacharge,double balance)
        {
            double walletBalance=balance+reacharge;
            return walletBalance;
        }

        public int DeductBalance(int amount,int balance)
        {
            int deductBalance=balance-amount;
            return deductBalance;
        }

    }
}