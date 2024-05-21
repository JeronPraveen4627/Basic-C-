using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private static int s_userID=1001;

        public string UserID{get;}
        private  double _balance;

        public string WorkStationNumber{get;set;}

        public double WalletBalance{get{return _balance;}}

        public UserDetails(string name,string fatherName,Gender gender,string mobile,string mailID,string workStationNumber,double walletBalance):base(name,fatherName,gender, mobile, mailID)
        {
            UserID="SF"+(++s_userID);
            WorkStationNumber=workStationNumber;
            _balance=walletBalance;
            // Name=name;
            // FatherName=fatherName;
            // Gender=gender;
            // Mobile=mobile;
            // MailID=mailID;

        }

        public  void WalletRecharge(double amount)
        {
            _balance+=amount;
        }

        public void ShowWalletBalance()
        {
            Console.WriteLine($"Balance Amount: {WalletBalance}");
        }







    }
}