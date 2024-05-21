using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public enum Gender{Select, Male, Female}
namespace BankAccount
{
    public class AccountDetails
    {
        /// <summary>
        /// This Class Used to Create a Account Details
        /// </summary>
        /// //Fields

        private static int s_customerId =1000;
        private string _custumerId = "";
        //Properties
        public string CustomerId { get;  }

        public string CustomerName  { get; set; }  

        public int Balance { get; set; } 

        public long PhoneNumber { get; set; } 

        public string MailId { get; set; } 

        public DateTime DOB { get; set; }  
        public Gender Gender { get; set; }


        public AccountDetails(string name,int bal, long phn ,string mail, DateTime dob, Gender gender)
        {
            s_customerId++;
            CustomerId = "HDFC" + s_customerId;
            CustomerName= name;
            Balance= bal;
            PhoneNumber= phn;
            MailId=mail;
            DOB = dob;
            Gender = gender;
        } 

        public int Deposit(int amount)
        {
            Balance = Balance+amount;
            return Balance;
        }
        public int withdraw(int amount)
        {
            Balance=Balance-amount;
            return Balance;
        }

    }
}