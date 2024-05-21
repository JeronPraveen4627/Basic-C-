using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        //CustomerID {Auto Increment – CID1000}, WalletBalance
        private static int s_customer=1000;

        public string CustomerID{get;}

        public double WalletBalance{get;set;}

        public CustomerDetails(double walletRecharger,string name, string fatherName,string gender, string mobile,DateTime dob,string mailID):base(name,fatherName, gender,mobile,dob,mailID)
        {
            CustomerID="CID"+(++s_customer);
            WalletBalance=walletRecharger;
        }
        
        public  void WalletRecharge(double amount)
        {
            WalletBalance=WalletBalance+amount;
        }


    }
}