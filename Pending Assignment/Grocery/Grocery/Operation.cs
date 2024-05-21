using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public static class Operation
    {
        public static CustomerDetails CurrentLoggedInCustomer;
        
       public  static List<CustomerDetails> customerList=new List<CustomerDetails>();
       public static List<ProductDetails> productList=new List<ProductDetails>();
        
        public static List<BookingDetails> bookList=new List<BookingDetails>();
        public static List<OrderDetails> orderList=new List<OrderDetails>();

        public static void MainMenu()
        {
             Console.WriteLine("*************************Online Grocery Store Application*************************");
            string mainChoice="yes";
            do{
            //Need to show Main Menu option
            Console.WriteLine("1.Customer Registration\n2.Customer Login\n3.Exit");
            //need to get input from user
            Console.Write("Select an option : ");
            int mainOption=int.Parse(Console.ReadLine());
            //Create Main Menu Structure
            switch(mainOption)
            {
               case 1:
               {
                Console.WriteLine("******************Customer Registration******************");
                CustomerRegistration();
                
                break;
               } 
               case 2:
               {
                Console.WriteLine("******************Customer Login ******************");
                CustomerLogin();
                
                break;
               }
               case 3:
               {
                Console.WriteLine("****************** Department wise seat Availability ******************");
               
                break;
               }
               case 4:
               {
                
                Console.WriteLine("application Ended Successfully");
                mainChoice="no";
                break;
               }
            }
            //Need to Iterate until the option is 4
            }while(mainChoice=="yes");
       }
        public static void CustomerRegistration()
        {

            Console.Write("Enter WalletBalance: ");
            double walletRecharger=double.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Your Father Name: ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your Date Of Birth: ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter your Gender: ");
            string gender=Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter your MailID: ");
            string mailID=Console.ReadLine();
            CustomerDetails customer=new CustomerDetails(walletRecharger,name,fatherName,gender,phoneNumber,dob,mailID);
            //Need to add in the list
            customerList.Add(customer);
            //Need to Display conformation message and ID
            Console.WriteLine($"Registration successfully completed Your ID is : {customer.CustomerID}");


        }

        public static void CustomerLogin()
        {
            Console.WriteLine("Enter Your CustomerID: ");
            string login=Console.ReadLine();
            bool flag=true;
            foreach(CustomerDetails customer in customerList)
            {
                if(login.Equals(customer.CustomerID))
                {
                    flag=false;
                    CurrentLoggedInCustomer=customer;
                    Console.WriteLine("Login Successfully");
                    SubMenu();
                }
            
            }
            if(flag)
            {
                Console.WriteLine("Invalid ID");
            }
        }

        public static void SubMenu()
        {
            string subChoice="yes";
        do
        {
            Console.WriteLine("***************Sub Menu ***************");
            //Need to show SubMenu Option
            Console.WriteLine("Select an option\n1.Show Customer Details\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Modify Order Quantity\n6.Exit");
            //Getting user Option
            Console.Write("Select your Option: ");
            int subOption=int.Parse(Console.ReadLine());
            //Need to create Sub Menu structure
            switch(subOption)
            {
                case 1:
                {
                    Console.WriteLine("************* Show Customer Details ***************");
                    ShowCustomerDetails();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("************* Show Product Details ***************");
                    ShowProductDetails();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("************* Wallet Recharge ***************");
                    Console.Write("Enter Recharge amount: ");
                    double amount=double.Parse(Console.ReadLine());
                   CurrentLoggedInCustomer.WalletRecharge(amount);
                    break;
                }
                case 4:
                {
                    Console.WriteLine("************* Take Order ***************");
                    TakeOrder();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("************* Modify Order Quantity ***************");
                    
                    break;
                }
                case 6:
                {
                    Console.WriteLine("************* Taking to Main Menu ***************");
                    subChoice="no";
                    break;
                }
            }
            //Iterate till option is exit.
        }while(subChoice=="yes");
        }

        public static void ShowCustomerDetails()
        {
            foreach(CustomerDetails customer in customerList)
            {

                if(CurrentLoggedInCustomer.CustomerID.Equals(customer.CustomerID))
                {
                    Console.WriteLine($"{customer.CustomerID}|{customer.WalletBalance}|{customer.Name}|{customer.FatherName}|{customer.Gender}|{customer.Mobile}|{customer.DOB}|{customer.MailID}");
                }
               
            }
        }
        public static void ShowProductDetails()
        {
            Console.WriteLine("ProductID	|ProductName	|QuantityAvailable	|PricePerQuantity");
            foreach(ProductDetails product in productList)
            {
                Console.WriteLine($"{product.ProductID}|{product.ProductName}|{product.QuantityAvailable}|{product.PricePerQuantity}");
            }
        }
        

        public static void TakeOrder()
        {
            Console.Write("If you want to purchase yes/no: ");
            string orderChoice=Console.ReadLine();
            orderChoice=orderChoice.ToLower();
            if(orderChoice=="yes")
            {
                BookingDetails booking=new BookingDetails(CurrentLoggedInCustomer.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                List<OrderDetails> tempOrderList=new List<OrderDetails>();
                string choice;
                double totalPrice=0.0;
                do{
                    
                ShowProductDetails();
                Console.WriteLine("select a product by using ProductID ");
                string checkID=Console.ReadLine();
                bool flag=true;
                foreach(ProductDetails product in productList){
                if(checkID.Equals(product.ProductID))
                {
                    flag=false;
                    Console.WriteLine("Enter Purchase quantity");
                    int purchaseQuantity=int.Parse(Console.ReadLine());
                    if(product.QuantityAvailable>0)
                    {
                        OrderDetails order=new OrderDetails(booking.BookingID,product.ProductID,purchaseQuantity,product.PricePerQuantity);
                        tempOrderList.Add(order);
                         totalPrice=purchaseQuantity*product.PricePerQuantity;
                        Console.WriteLine("Product successfully added to cart");
                    }
                    else
                    {
                        Console.WriteLine("product is not available");
                    }
                }

                }
                if(flag)
                {
                    Console.WriteLine("Invalid ID");
                }
                Console.WriteLine("Do want to book another product: ");
                choice=Console.ReadLine();
                choice=choice.ToLower();
                }while(choice=="yes");
                Console.WriteLine("Do you want to confirm the order");
                string confirmation=Console.ReadLine();
                confirmation=confirmation.ToLower();
                if(confirmation=="yes")
                {
                    double balance= CurrentLoggedInCustomer.WalletBalance;
                    if(balance>=totalPrice)
                    {
                        //BookingDetails book=new BookingDetails(
                    }
                }

            }
        }

        public static void AddDefaultData()
        {
            CustomerDetails customer1=new CustomerDetails(10000,"Ravi","Ettapparajan","Male","974774646",DateTime.ParseExact("11/11/1999","dd/MM/yyyy",null),"ravi@gmail.com");
            CustomerDetails customer2=new CustomerDetails(15000,"Baskaran","Sethurajan","Male","847575775",DateTime.ParseExact("11/11/1999","dd/MM/yyyy",null),"baskaran@gmail.com");
            customerList.AddRange(new List<CustomerDetails>(){customer1,customer2});

            ProductDetails product1=new ProductDetails("Sugar",20,40);
            ProductDetails product2=new ProductDetails("Rice",100,50);
            ProductDetails product3=new ProductDetails("Milk",10,40);
            ProductDetails product4=new ProductDetails("Coffee",10,10);
            ProductDetails product5=new ProductDetails("Tea",10,10);
            ProductDetails product6=new ProductDetails("Masala Powder",10,20);
            productList.AddRange(new List<ProductDetails>(){product1,product2,product3,product4,product5,product6});

            BookingDetails booking1=new BookingDetails("CID1001",220,DateTime.ParseExact("26/07/2022","dd/MM/yyyy",null),BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("CID1002",400,DateTime.ParseExact("26/07/2022","dd/MM/yyyy",null),BookingStatus.Booked);
            BookingDetails booking3=new BookingDetails("CID1001",220,DateTime.ParseExact("26/07/2022","dd/MM/yyyy",null),BookingStatus.Booked);
            BookingDetails booking4=new BookingDetails("CID1001",280,DateTime.ParseExact("26/07/2022","dd/MM/yyyy",null),BookingStatus.Cancelled);
            BookingDetails booking5=new BookingDetails("CID1002",0,DateTime.ParseExact("26/07/2022","dd/MM/yyyy",null),BookingStatus.Initiated);
            bookList.AddRange(new List<BookingDetails>(){booking1,booking2,booking3,booking4,booking5}); 


            OrderDetails order1=new OrderDetails("BID3001","PID2001",2,80);
            OrderDetails order2=new OrderDetails("BID3001","PID2002",2,100);
            OrderDetails order3=new OrderDetails("BID3001","PID2003",1,40);
            OrderDetails order4=new OrderDetails("BID3002","PID2001",1,40);
            OrderDetails order5=new OrderDetails("BID3002","PID2002",4,200);
            OrderDetails order6=new OrderDetails("BID3002","PID2010",1,140);
            OrderDetails order7=new OrderDetails("BID3002","PID2009",1,20);
            OrderDetails order8=new OrderDetails("BID3003","PID2002",2,100);
            orderList.AddRange(new List<OrderDetails>(){order1,order2,order3,order4,order5,order6,order7,order8});
  
        }
   
    }
    }
