using System;
using System.Collections.Generic;
namespace EbBill;

class Program
{
    static List<BillCalculation> billList=new List<BillCalculation>();
    public static void Main(string[] args)
    {
        int number;
        do
        {
            Console.Write("1.Registration\n2.Login\n3.Exit");
            number=int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                {
                    Console.Write("Enter your name : ");
                    string name=Console.ReadLine();
                    Console.Write("Phone Number : ");
                    long phoneNumber=long.Parse(Console.ReadLine());
                    Console.Write("Enter your Mail ID : ");
                    string mailID=Console.ReadLine();
                    Console.Write("Enter Unit Used : ");
                    int unit=int.Parse(Console.ReadLine());

                    BillCalculation customer=new BillCalculation(name,phoneNumber,mailID,unit);
                    billList.Add(customer);
                    Console.WriteLine($"Your Meter ID : {customer.MeterID}");
                    break;
                }
                case 2:
                {
                    Console.Write("Enter Your Meter ID :");
                    string meterId=Console.ReadLine();
                    int subMenu;
                    for(int i=0;i<billList.Count;i++)
                    {
                        if(meterId==billList[i].MeterID)
                        {
                            Console.Write("1.Calculate Amount\n2.Display User Details\n3.Exit");
                            subMenu=int.Parse(Console.ReadLine());
                            switch(subMenu)
                            {
                                case 1:
                                {   
                                    Console.Write($"Your User Name : {billList[i].UserName}");
                                    Console.Write($"Unit Used : {billList[i].UnitUsed}");
                                    int amount=billList[i].AmountCalculate();
                                    Console.WriteLine($"Your Bill Amount is : {amount}");
                                    break;
                                }
                                case 2:
                                {
                                    Console.Write($"Your Meter ID :{billList[i].MeterID}");
                                    Console.Write($"User Name : {billList[i].UserName}");
                                    Console.WriteLine($"Phone Number: {billList[i].PhoneNumber}");
                                    Console.WriteLine($"MailId: {billList[i].MailID}");
                                    break;
                                }
                                case 3:
                                {
                                    break;
                                }
                            }
                            
                        }
                    }
                    break;
                }   
            }

        }while(number!=3);
    }
}