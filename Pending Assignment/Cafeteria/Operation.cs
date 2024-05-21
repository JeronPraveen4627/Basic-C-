using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class Operation
    {
        public static UserDetails CurrentLoggin;
        public static List<FoodDetails> foodList = new List<FoodDetails>();
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<OrderDetails> orderList = new List<OrderDetails>();

        public static List<CartItem> cardList=new List<CartItem>();

        public static void MainMenu()
        {
             Console.WriteLine("*************************Online Grocery Store Application*************************");
            string mainChoice="yes";
            do{
            //Need to show Main Menu option
            Console.WriteLine("1.User Registration\n2.User Login\n3.Exit");
            //need to get input from user
            Console.Write("Select an option : ");
            int mainOption=int.Parse(Console.ReadLine());
            //Create Main Menu Structure
            switch(mainOption)
            {
               case 1:
               {
                Console.WriteLine("******************User Registration******************");
                UserRegistration();
                
                break;
               } 
               case 2:
               {
                Console.WriteLine("******************User Login ******************");
                UserLogin();
                
                break;
               }
               case 3:
               {
                
                Console.WriteLine("application Ended Successfully");
                mainChoice="no";
                break;
               }
            }
            //Need to Iterate until the option is 4
            }while(mainChoice=="yes");
       }
        public static void UserRegistration()
        {

            Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your Father Name: ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter your Phone Number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter your MailID: ");
            string mailID=Console.ReadLine();
            Console.Write("Enter your WorkStation Number: ");
            string workstation=Console.ReadLine();
            Console.Write("Enter your Wallet Balance: ");
            double walletBalance=double.Parse(Console.ReadLine());
        
            UserDetails user=new UserDetails(name,fatherName,gender,phoneNumber,mailID,workstation,walletBalance);
            //Need to add in the list
            userList.Add(user);
            //Need to Display conformation message and ID
            Console.WriteLine($"Registration successfully completed Your ID is : {user.UserID}");


        }

        public static void UserLogin()
        {
            Console.WriteLine("Enter Your UserID: ");
            string login=Console.ReadLine();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(login.Equals(user.UserID))
                {
                    flag=false;
                    CurrentLoggin=user;
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
            Console.WriteLine("Select an option\n1.Show My Profile\n2.Food Order\n3.Modify Order\n4.Cancel Order\n5.Order History \n6.Wallet Recharge\n7.Show Wallet Balance\n8.Exit");
            //Getting user Option
            Console.Write("Select your Option: ");
            int subOption=int.Parse(Console.ReadLine());
            //Need to create Sub Menu structure
            switch(subOption)
            {
                case 1:
                {
                    Console.WriteLine("************* My Profile ***************");
                    ShowMyProfile();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("************* Food Order ***************");
                   // FoodOrder();
                    break;
                }
                 case 3:
                {
                    Console.WriteLine("************* Modify Order ***************");
                   // ModifyOrder();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("************* Cancel Order ***************");
                    //CancelOrder();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("************* Order Histroy***************");
                    OrderHistory();
                    break;
                }

                case 6:
                {
                    Console.WriteLine("************* Wallet Recharge ***************");
                    Console.Write("Enter Recharge amount: ");
                    double amount=double.Parse(Console.ReadLine());
                   CurrentLoggin.WalletRecharge(amount);
                    break;
                }
                case 7:
                {
                    Console.WriteLine("************* Wallet Balance ***************");
                   CurrentLoggin.ShowWalletBalance();
                    break;
                }
                case 8:
                {
                    Console.WriteLine("************* Taking to Main Menu ***************");
                    subChoice="no";
                    break;
                }
            }
            //Iterate till option is exit.
        }while(subChoice=="yes");
        }

        public static void ShowMyProfile()
        {
            foreach(UserDetails user in userList)
            {

                if(CurrentLoggin.UserID.Equals(user.UserID))
                {
                    Console.WriteLine($"{user.UserID}|{user.Name}|{user.FatherName}|{user.Gender}|{user.Mobile}|{user.MailID}|{user.WorkStationNumber}|{user.WalletBalance}|");
                }
               
            }
        }
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(CurrentLoggin.UserID.Equals(order.UserID))
                {
                    Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.OrderDate}|{order.TotalPrice}|{order.OrderStatus}");
                }
            }
        }
        public void AddDefaultValues()
        {
            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.AddRange(new List<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7 });


            UserDetails user1=new UserDetails("Ravichandran","Ettapparajan",Gender.Male,"8857777575","ravi@gmail.com","WS101",400);
            UserDetails user2=new UserDetails("Baskaran","Sethurajan",Gender.Male,"9577747744","baskaran@gmail.com","WS105",500);
            userList.AddRange(new List<UserDetails>(){user1,user2});

            OrderDetails order1=new OrderDetails("SF1001",DateTime.ParseExact("15/06/2022","dd/MM/yyyy",null),70,OrderStatus.Ordered);
            OrderDetails order2=new OrderDetails("SF1002",DateTime.ParseExact("15/06/2022","dd/MM/yyyy",null),100,OrderStatus.Ordered);
            orderList.AddRange(new List<OrderDetails>(){order1,order2});

            CartItem card1=new CartItem("OID1001","FID101",20,1);
            CartItem card2=new CartItem("OID1001","FID103",10,1);
            CartItem card3=new CartItem("OID1001","FID105",40,1);
            CartItem card4=new CartItem("OID1002","FID103",10,1);
            CartItem card5=new CartItem("OID1002","FID104",50,1);
            CartItem card6=new CartItem("OID1002","FID105",40,1);
            cardList.AddRange(new List<CartItem>(){card1,card2,card3,card4,card5,card6});


        }


    }
}