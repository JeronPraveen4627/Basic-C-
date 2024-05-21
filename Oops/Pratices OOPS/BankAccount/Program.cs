using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
namespace BankAccount;

class Program
{
    static List<AccountDetails> accountList = new List<AccountDetails>();
    public static void Main(string[] args)
    {
        
        
        int option;
        do{
            Console.WriteLine("1.Registration.");
            Console.WriteLine("2.Login.");
            Console.WriteLine("3.Exit.");
            option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string check;
                do
                {
                    
                        //AccountDetails customer1 = new AccountDetails();
                        
                        Console.Write("Enter Your Name: ");
                        string customerName=Console.ReadLine();
                        Console.Write("Your Balance Amount : ");
                        int balance=int.Parse(Console.ReadLine());
                        Console.Write("Enter Your Phone Number: ");
                        long phoneNumber=long.Parse(Console.ReadLine());
                        Console.Write("Enter Your Mail ID: ");
                        string mailId=Console.ReadLine();
                        Console.Write("Enter Your Date Of Birth: ");
                        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                        Console.Write("Enter gender: ");
                        Gender gender= Enum.Parse<Gender>(Console.ReadLine());
                        
                        AccountDetails customer = new AccountDetails(customerName, balance,phoneNumber,mailId,dob, gender);
                        accountList.Add(customer);
                        Console.WriteLine($"Your CustomerID is {customer.CustomerId}");
                
                Console.WriteLine("Do you want to create Another user : yes/no ");  
                check=Console.ReadLine();
                }while(check=="yes");
                break;
            }
            case 2:
                {
                    Console.Write("Enter your customer ID : ");
                    string loginId = Console.ReadLine();
                    for(int i=0; i< accountList.Count; i++)
                    {
                        if(loginId== accountList[i].CustomerId)
                        {
                            int subMenuOption;
                            do{
                            Console.WriteLine($"Hi {accountList[i].CustomerName}");
                            Console.WriteLine("1.Deposit\n2.Withdraw\n3.Balance Check\n4.Exit");
                             subMenuOption = int.Parse(Console.ReadLine());
                            switch(subMenuOption)
                            {
                                case 1:
                                {
                                    Console.Write("Enter Deposit amount: ");
                                    int amount = int.Parse(Console.ReadLine());
                                    int currentBalance = accountList[i].Deposit(amount);
                                    Console.WriteLine($"Your Balance: {currentBalance}");
                                    break;
                                }
                                case 2:
                                {
                                    Console.Write("Enter Withdraw Amount: ");
                                    int amount =int.Parse(Console.ReadLine());
                                    int balance=accountList[i].withdraw(amount);
                                    Console.WriteLine($"Current Balance: {balance}");
                                    break;
                                }
                                case 3:
                                {
                                    Console.WriteLine($"Current Balance {accountList[i].Balance}");
                                    break;
                                }
                                case 4:
                                {
                                    Console.WriteLine("Returned to Main Menu");
                                    break;
                                }
                            }
                            }while(subMenuOption!=4);
                        }
                        else if(i==accountList.Count-1)
                        {
                            Console.WriteLine("Invalid Id");
                        }
                    }
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Application Ended");
                    break;
                }
        }
   }while(option!=3);
    }

    }

