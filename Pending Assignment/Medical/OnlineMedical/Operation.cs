using System;
using System.Collections;
using System.Data.Common;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace OnlineMedical
{
    public static class Operation
    {
        public static UserDetails CurrentLogginID;
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicineList=new CustomList<MedicineDetails>();

        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();

        public static void MainMenu()
        {
            bool flag=true;
            do{
            Console.Write("1.User Registration\n2.User Login\n3.Exit\nEnter Option: ");
            int optionMainMenu=int.Parse(Console.ReadLine());
            switch(optionMainMenu)
            {
                case 1:
                {
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    UserLogin();
                    break;
                }
                case 3:
                {
                    flag=false;
                    break;
                }
            }
        }while(flag);
        }

        public static void UserRegistration()
        {
            Console.Write("Enter Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your age: ");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter your City: ");
            string city=Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter Balance amount: ");
            double walletBalance=double.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(name,age,city,phoneNumber,walletBalance);
            userList.Add(user);
            Console.WriteLine($"UserID: {user.UserID}");
        }

        public static void UserLogin()
        {
            Console.Write("Enter Login ID:");
            string checkID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(checkID.Equals(user.UserID))
                {
                    flag=false;
                    CurrentLogginID=user;
                    SubMenu();
                }
            }
            if(flag)
            {
                Console.WriteLine("Enter Valid ID");
            }
        }

        public static void SubMenu()
        {
            bool flag=true;
            do{
            Console.Write("1.Show Medicine list\n2.Purchase medicine\n3.Modify Purchase\n4.Cancel purchase\n5.Show purchase history\n6.Recharge Wallet\n7.Show Balance Wallet\n8.Exit\nEnter Submenu option: ");
            int subMenu=int.Parse(Console.ReadLine());
            switch(subMenu)
            {
                case 1:
                {
                    ShowMedicineList();
                    break;
                }
                case 2:
                {
                    PurchaseMedicineList();
                    break;
                }
                case 3:
                {
                    ModifyPurchase();
                    break;
                }
                case 4:
                {
                    CancelPurchase();
                    break;
                }
                case 5:
                {
                    PurchaseHistory();
                    break;
                }
                case 6:
                {
                    RechargeWallet();
                    break;
                }
                case 7:
                {
                    ShowWalletBalance();
                    break;
                }
                case 8:
                {
                    flag=false;
                    break;
                }
            }
            
            }while(flag);
        }

        public static void ShowMedicineList()
        {
            Console.WriteLine("|MedicineID	|MedicineName	|Available Count   |Price |DateOfExpiry|");
            foreach(MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"|{medicine.MedicineID}  |{medicine.MedicineName}  |{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            }
        }
        public static void PurchaseMedicineList()
        {
            Console.WriteLine("|MedicineID	|MedicineName	|Available Count   |Price |DateOfExpiry|");
            foreach(MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"|{medicine.MedicineID}  |{medicine.MedicineName}  |{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            }
            double amount;
            Console.Write("Enter Medicine ID:");
            string medicineID=Console.ReadLine();
            Console.Write("Enter No.of Count of Medicine: ");
            int count=int.Parse(Console.ReadLine());
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicineID.Equals(medicine.MedicineID))
                {
                    if(count<=medicine.AvailableCount)
                    {
                        if(DateTime.Now<=medicine.DateOfExpiry)
                        {
                            amount=count*medicine.Price;
                            if(CurrentLogginID.WalletBalance>=amount)
                            {
                                medicine.AvailableCount=medicine.AvailableCount-count;
                                CurrentLogginID.DeductBalance(amount);
                                OrderDetails order=new OrderDetails(CurrentLogginID.UserID,medicine.MedicineID,count,amount,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(order);
                                Console.Write("Medicine was purchased successfully");
                            }   
                        }
                        else
                        {
                            Console.Write("Medicine is Expried");
                        }
                    }
                    else
                    {
                        Console.Write("Medicine is not Available");
                    }
                }
            }
            Console.WriteLine();
        }
        public static void ModifyPurchase()
        {
            foreach(OrderDetails order in orderList)
            {
                if(CurrentLogginID.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    // foreach(OrderDetails order1 in orderList)
                    // {
                        Console.WriteLine($"{order.UserID}|{order.OrderID}|{order.MedicineID}|{order.MedicineCount}|{order.OrderDate}|{order.OrderStatus}|");
                    // }
                    Console.Write("Enter new quantity:");
                    int quantity=int.Parse(Console.ReadLine());
                    if(quantity>order.MedicineCount)
                    {
                        order.MedicineCount=quantity;
                        order.TotalPrice=quantity*(order.TotalPrice/order.MedicineCount);
                    }
                    else
                    {
                        order.MedicineCount=quantity;
                        double price=quantity*order.TotalPrice/quantity;
                        order.TotalPrice-=quantity*price;
                    }

                }
            }
        }
        public static void CancelPurchase()
        {
            foreach(OrderDetails order in orderList)
            {
                if(OrderStatus.Purchased.Equals(OrderStatus.Purchased))
                {
                    Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                }
               
            }
            foreach(OrderDetails order in orderList)
            {
                if(OrderStatus.Purchased.Equals(OrderStatus.Purchased))
                {
                    Console.WriteLine("Enter Order ID: ");
                    string orderID=Console.ReadLine();
                    if(orderID.Equals(order.OrderID))
                    {
                        //CurrentLogginID.medicine
                    }
                
                }
                
               
            }
        }
        public static void PurchaseHistory()
        {
            Console.WriteLine("OrderID|UserID|MedicineID |MedicineCount| TotalPrice|OrderDate|OrderStatus|");
            foreach(OrderDetails order in orderList)
            {
                if(CurrentLogginID.UserID.Equals(order.OrderID))
                {
                    Console.WriteLine($"{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
                }
            }
        }
        public static void RechargeWallet()
        {
            Console.WriteLine("Enter Recharge Amount: ");
            double recharge=double.Parse(Console.ReadLine());
            CurrentLogginID.WalletRecharger(recharge);
        }
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your Balance amount is : {CurrentLogginID.WalletBalance}");
        }


        public static void AddDefaultValue()
        {
            UserDetails user1=new UserDetails("Ravi",33,"Theni","9877774440",400);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai","8847757470",500);
            userList.AddRange(new CustomList<UserDetails>(){user1,user2});

            // Console.WriteLine("|UserID	|UserName	|Age	|City	|Phone Number	|Balance|");
            // foreach(UserDetails user in userList)
            // {
            //     Console.WriteLine($"|{user.UserID}  |{user.Name}   |{user.Age}|{user.City}    |{user.PhoneNumber}|{user.WalletBalance}|");
            // }

            MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,DateTime.ParseExact("30/06/2024","dd/MM/yyyy",null));
            MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,DateTime.ParseExact("30/05/2024","dd/MM/yyyy",null));
            MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,DateTime.ParseExact("30/04/2024","dd/MM/yyyy",null));
            MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,DateTime.ParseExact("30/12/2024","dd/MM/yyyy",null));
            MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,DateTime.ParseExact("30/12/2024","dd/MM/yyyy",null));
            medicineList.AddRange(new CustomList<MedicineDetails>(){medicine1,medicine2,medicine3,medicine4,medicine5});

            // Console.WriteLine("|MedicineID	|MedicineName	|Available Count   |Price |DateOfExpiry|");
            // foreach(MedicineDetails medicine in medicineList)
            // {
            //     Console.WriteLine($"|{medicine.MedicineID}  |{medicine.MedicineName}  |{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            // }

            OrderDetails order1=new OrderDetails("UID1001","MD101",3,15,DateTime.ParseExact("13/11/2022","dd/MM/yyyy",null),OrderStatus.Purchased);
            OrderDetails order2=new OrderDetails("UID1001","MD102",2,10,DateTime.ParseExact("13/11/2022","dd/MM/yyyy",null),OrderStatus.Cancelled);
            OrderDetails order3=new OrderDetails("UID1001","MD104",2,100,DateTime.ParseExact("13/11/2022","dd/MM/yyyy",null),OrderStatus.Purchased);
            OrderDetails order4=new OrderDetails("UID1002","MD103",3,120,DateTime.ParseExact("15/11/2022","dd/MM/yyyy",null),OrderStatus.Cancelled);
            OrderDetails order5=new OrderDetails("UID1002","MD105",5,250,DateTime.ParseExact("15/11/2022","dd/MM/yyyy",null),OrderStatus.Purchased);
            OrderDetails order6=new OrderDetails("UID1002","MD102",3,15,DateTime.ParseExact("15/11/2022","dd/MM/yyyy",null),OrderStatus.Purchased);  

            orderList.AddRange(new CustomList<OrderDetails>(){order1,order2,order3,order4,order5,order6});
            // Console.WriteLine("|OrderID	|UserID	|MedicineID	|MedicineCount	|TotalPrice	|OrderDate	|OrderStatus");
            // foreach(OrderDetails order in orderList)
            // {
            //     Console.WriteLine($"|{order.OrderID}|{order.UserID}|{order.MedicineID}|{order.MedicineCount}|{order.TotalPrice}|{order.OrderDate.ToString("dd/MM/yyyy")}|{order.OrderStatus}|");
            // }


             	

            

        }
    }
}