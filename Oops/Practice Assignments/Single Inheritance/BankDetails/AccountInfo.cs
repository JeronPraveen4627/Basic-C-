using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace BankDetails
{
    public class AccountInfo:PersonalInfo
    {
//         Properties: AccountNumber, BranchName, IFSCCode, Balance

// Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.
        public long AccountNumber{get; set;}

        public string Branch{get;set;}

        public string IFSCCode{get;set;}

        public double Balance{get;set;}

        public AccountInfo(string name,string fatherName,long phone,string mailID,DateTime dob,string gender,long accountNumber, string branch, string IFSCcode,double balance):base(name, fatherName,phone, mailID, dob, gender)
        {
            AccountNumber=accountNumber;
            Branch=branch;
            IFSCCode=IFSCcode;
            Balance=balance;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}\nIFSC Code: {IFSCCode}\nBranch: {Branch}\nBalance: {Balance}");
            Console.WriteLine($"Name: {Name}\nFather Name: {FatherName}\nPhone: {Phone}\nMail ID: {MailID}\nDOB: {DOB.ToShortDateString()}");
           // Console.WriteLine("");
        }

        public void Deposite()
        {
            Console.WriteLine("Enter your Deposite Amount: ");
            double deposite=double.Parse(Console.ReadLine());
            Balance=Balance+deposite;
           // Console.WriteLine($"Balance: {Balance}");
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter your Withdraw Amount: ");
            double Withdraw=double.Parse(Console.ReadLine());
            Balance=Balance-Withdraw;
           // Console.WriteLine($"Balance: {Balance}");

        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }

    }
}