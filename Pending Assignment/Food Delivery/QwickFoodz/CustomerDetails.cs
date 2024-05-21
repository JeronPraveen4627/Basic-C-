using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static double _balance;

        private static int s_customerID=1000;

        public string CustomerID{get;}

        public double WalletBalance{get{return _balance;}}

        public CustomerDetails(double walletBalance,string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID ):base(name, fatherName, gender, mobile, dob, mailID )
        {
            CustomerID="CID"+(++s_customerID);
            _balance=walletBalance;
        }

        public static void WalletRecharge(double amount)
        {
            _balance+=amount;
        }

        public static void DeductBalance(double amount)
        {
            _balance-=amount;
        }


    }
}