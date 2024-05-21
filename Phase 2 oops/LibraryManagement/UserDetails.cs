using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public enum Department{ECE,EEE,CSE}
    public enum Gender{Male,Female,Transgender}
    public class UserDetails
    {
        //private field
        private static int s_userID=3000;

        /*Properties:
            UserID (Auto Increment – SF3003)
            UserName
            Gender
            Department – (Enum – ECE, EEE, CSE)
            MobileNumber
            MailID
            WalletBalance */
            
        public string UserID{get;}    
        public string UserName{get; set;}

        public Gender Gender{get; set;}

        public Department Department{get; set;}

        public long MobileNumber{get; set;}

        public string MailID{get; set;}

        public double WalletBalance{get; set;}


        public UserDetails(string userName,Gender gender,Department department,long mobileNumber,string mailID,double walletBalance)
        {
            s_userID++;
            UserID="SF"+s_userID;
            UserName=userName;
            Gender=gender;
            Department=department;
            MobileNumber=mobileNumber;
            MailID=mailID;
            WalletBalance=walletBalance;
        }

       //WalletRecharge Method 
        public double WalletRecharge(double amount)
            {
                double walletRecharge=WalletBalance+amount;
                WalletBalance=walletRecharge;
                return walletRecharge;
            }

        public double DeductBalance(double deductAmount)
        {
            double deductBalance=WalletBalance-deductAmount;
            return deductBalance;
        }
    }
}