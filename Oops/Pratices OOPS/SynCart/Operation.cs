using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SynCart
{
    public static class Operation
    {
       static List<CustomerDetails> customerList=new List<CustomerDetails>();
       static List<ProductDetails> productList = new List<ProductDetails>();
        public static void MainMenu()
        {
            string mainChoice;
            do{
                mainChoice="yes";
                Console.Write("1.Customer Registration\n2.login\n3.Exit\n Select one Operation to be performed : ");
                int menuOption=int.Parse(Console.ReadLine());
             switch(menuOption)
             {
                case 1:
                    {
                       Registration();
                        break;
                    }
                case 2:
                {
                    CustomerLogin();
                    break;
                }
                case 3:
                {
                    mainChoice="no";
                    Console.WriteLine("Application Ended");
                    break;
                }
             }
             Console.WriteLine("Do you want to continue");
             //mainChoice
             
            }while(mainChoice=="yes");
        }
     
    //Registration
    public static void Registration()
    {
     Console.Write("Enter Your Name : ");
     string customerName=Console.ReadLine();
     Console.Write("Enter Your City : ");
     string customerCity=Console.ReadLine();
     Console.Write("Enter Your Phone Number : ");
     long phoneNumber=long.Parse(Console.ReadLine());
     Console.Write("Enter your Mail ID : ");
     string mailID = Console.ReadLine();
     Console.Write("Enter Your Wallet Balance : ");
     double walletBalance=double.Parse(Console.ReadLine());

     CustomerDetails customer=new CustomerDetails(customerName,customerCity,phoneNumber,mailID,walletBalance);
     customerList.Add(customer);
     Console.WriteLine($"Your Customer ID :{customer.CustomerID}");
    }//Registration Ended
    
    public static void CustomerLogin()
    {
        Console.Write("Enter Your Login: ");
        string login=Console.ReadLine();
        bool flag=true;
        foreach(CustomerDetails customer in customerList)
        {
            if(customer.CustomerID==login)
            {
                flag=false;
                Console.WriteLine("Successfully login");
            }
        }
        if(flag)
       Console.WriteLine("Invalid ID");
    }




    public static void AddDefaultData()
    {
        ProductDetails product1=new ProductDetails("Mobile (Samsung)",10,10000,3);
        ProductDetails product2=new ProductDetails("Tablet (Lenovo)",5,15000,2);
        productList.AddRange(new List<ProductDetails>(){product1,product2});



    }
    }

    
}