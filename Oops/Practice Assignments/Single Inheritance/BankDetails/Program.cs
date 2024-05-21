using System;
namespace BankDetails;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Jeron","Sivaraman",9655857478,"Jeron@gmail.com",DateTime.ParseExact("05/02/2001","dd/MM/yyyy",null),"Male");
        AccountInfo account=new AccountInfo(person.Name,person.FatherName,person.Phone,person.MailID,person.DOB,person.Gender,858574964563,"Chennai","ABCD1234",10000);
        account.ShowAccountInfo();
        account.Deposite();
        account.Withdraw();
        account.ShowBalance();
    }
}