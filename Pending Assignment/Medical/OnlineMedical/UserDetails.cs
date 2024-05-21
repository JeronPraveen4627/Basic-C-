using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID=1000;
        private double _balance;

        public string UserID{get;}

        public double WalletBalance
        {
            get
            {
                return  _balance;
            }
        }

        public UserDetails(string name,int age, string city,string phoneNumber,double walletBalance):base(name,age, city, phoneNumber)
        {
            UserID="UID"+(++s_userID);
            _balance=walletBalance;
        }
        public UserDetails(string user):base()
        {
            string[] values=user.Split(",");
            UserID=values[0];
            s_userID=int.Parse(values[0].Remove(0,3));
            Name=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=values[4];
            _balance=double.Parse(values[5]);
        
        }

        public void WalletRecharger(double amount)
        {
            _balance+=amount;
        }

        public  void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
   
}