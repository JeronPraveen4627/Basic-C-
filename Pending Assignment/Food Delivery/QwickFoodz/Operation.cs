using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class Operation
    {
        public static CustomerDetails CurrentLoginID;
        static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();

        static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        static CustomList<ItemDetails> itemList = new CustomList<ItemDetails>();

        static CustomList<ItemDetails> localtempList = new CustomList<ItemDetails>();

        public static void MainMenu()
        {
            Console.WriteLine();
            bool flag = true;
            do
            {
                Console.Write("1.Registration\n2.User Login\n3.Exit\nEnter Option: ");
                int mainMenuOption = int.Parse(Console.ReadLine());
                switch (mainMenuOption)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            Console.WriteLine("************************* Application Ended *************************");
                            break;
                        }

                }
            } while (flag);
        }

        public static void Registration()
        {
            Console.WriteLine("********************** Registration **********************");
            Console.Write("Wallet Balance: ");
            double walletBalance = double.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Father Name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("DOB: ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Mail ID: ");
            string mailID = Console.ReadLine();

            CustomerDetails customer = new CustomerDetails(walletBalance, name, fatherName, gender, phoneNumber, dob, mailID);
            customerList.Add(customer);
            Console.WriteLine($"Your Customer ID:{customer.CustomerID}\nYour Location:{customer.Location}");
            Console.WriteLine();
        }

        public static void UserLogin()
        {
            Console.WriteLine("********************** User Login **********************");
            Console.Write("Enter your user ID: ");
            string checkID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (checkID.Equals(customer.CustomerID))
                {
                    CurrentLoginID = customer;
                    flag = false;
                    Console.WriteLine("***************** Successfully Login *****************");
                    SubMenu();
                }
            }
            if (flag)
            {
                Console.Write("Invalid ID");
            }
        }

        public static void SubMenu()
        {
            Console.WriteLine("       ***************** Sub Menu *****************");
            bool flag = true;
            do
            {
                Console.WriteLine("1.Show Profile\n2.Order Food\n3.Cancel Order\n4.Modify Order\n5.Order Histroy\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                int optionSubMenu = int.Parse(Console.ReadLine());

                switch (optionSubMenu)
                {
                    case 1:
                        {
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    case 4:
                        {
                            ModifyOrder();
                            break;
                        }
                    case 5:
                        {
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            ShowBalance();
                            break;
                        }
                    case 8:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public static void ShowProfile()
        {
            Console.WriteLine("CustomerID	|WalletBalance|Name	    |FatherName	  |Gender	|Mobile	   |DOB	 |MailID	|Location");
            foreach (CustomerDetails customer in customerList)
            {
                if (CurrentLoginID.CustomerID.Equals(customer.CustomerID))
                {
                    Console.WriteLine($"{customer.CustomerID}|{customer.WalletBalance}|{customer.Name}      |{customer.FatherName}     |{customer.Gender}    |{customer.Mobile}   |{customer.DOB}|{customer.MailID}    |{customer.Location}|");
                }
            }
            Console.WriteLine();
        }

        public static void OrderFood()
        {
            OrderDetails neworder = new OrderDetails(CurrentLoginID.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            orderList.Add(neworder);
            string checkloop;
            do{
            Console.WriteLine("FoodID |FoodName       |PricePerQuantity|QuantityAvailable");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"{food.FoodID}|{food.FoodName}|{food.PricePerQuantity}|{food.QuantityAvailable}|");
            }
            bool flag = true;
            Console.Write("Enter Food ID : ");
            string foodID = Console.ReadLine().ToUpper();
            Console.Write("Enter Food Quantity : ");
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice;
            foreach (FoodDetails food in foodList)
            {
                if (foodID.Equals(food.FoodID) && quantity <= food.QuantityAvailable)
                {
                    flag=false;
                    totalPrice=food.PricePerQuantity;

                }
            }
            if (flag)
            {
                Console.WriteLine("Food is Unavailable");
            }
            else
            {
                foreach (ItemDetails item in itemList)
                    {
                        if (foodID.Equals(item.FoodID))
                        {
                            flag=false;
                            ItemDetails wish = new ItemDetails(item.OrderID, foodID, quantity, quantity * item.PriceOfOrder);
                            itemList.Add(wish);
                            
                            Console.WriteLine("Your Food is Successfully Added in cart");
                        }
                    }
            }
            Console.WriteLine("If you want do order More yes/no: ");
            checkloop=Console.ReadLine().ToUpper();

        }while(checkloop=="YES");

        Console.WriteLine("Do you want to Confirm this Order yes/no:");
        string status=Console.ReadLine().ToUpper();

        }

        public static void ModifyOrder()
        {
            foreach (OrderDetails order in orderList)
            {
                if (CurrentLoginID.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"{order.OrderID}|{order.CustomerID}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}");
                }
            }
            Console.WriteLine("Enter Order ID: ");
            string orderID = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in orderList)
            {
                if (orderID.Equals(order.OrderID) && CurrentLoginID.CustomerID.Equals(order.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"{order.OrderID}|{order.CustomerID}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}");
                }
            }

            Console.WriteLine("Enter Item ID: ");
            string itemID = Console.ReadLine().ToUpper();
            foreach (ItemDetails item in itemList)
            {
                if ( orderID.Equals(item.ItemID) && itemID.Equals(item.ItemID))
                {
                    Console.Write("Enter new item Quantity: ");
                    int newQuantity = int.Parse(Console.ReadLine());
                    double price = item.PriceOfOrder / item.PurchaseCount;
                    item.PurchaseCount = newQuantity;
                    if (CurrentLoginID.WalletBalance >= price)
                    {
                        CustomerDetails.DeductBalance(price);
                    }
                    else
                    {
                        double balance = price - CurrentLoginID.WalletBalance;
                        Console.WriteLine($"Your Balance Amount is : {balance}");
                    }
                }
            }
        }
            public static void CancelOrder()
            {
                foreach (OrderDetails order in orderList)
                {
                    if (CurrentLoginID.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        Console.WriteLine("Enter Order ID to be Cancelled : ");
                        string checkID = Console.ReadLine();
                        if (checkID.Equals(order.OrderID))
                        {
                            order.OrderStatus = OrderStatus.Cancelled;
                            double amount = order.TotalPrice;
                            CustomerDetails.WalletRecharge(amount);

                        }
                    }

                }
            }
            public static void OrderHistory()
            {
                Console.WriteLine("OrderID |CustomerID|TotalPrice|DateOfOrder |OrderStatus|");
                foreach (OrderDetails order in orderList)
                {
                    if (CurrentLoginID.CustomerID.Equals(order.CustomerID))
                    {
                        Console.WriteLine($"{order.OrderID}|{order.CustomerID}|{order.DateOfOrder.ToString("dd/MM/yyyy")}|{order.TotalPrice}|{order.OrderStatus}|");
                    }
                }
            }

            public static void RechargeWallet()
            {
                Console.WriteLine("Enter Recharge Amount: ");
                double rechargeAmount = double.Parse(Console.ReadLine());
                CustomerDetails.WalletRecharge(rechargeAmount);

            }
            public static void ShowBalance()
            {
                Console.WriteLine($"Your Balance  Amount is: {CurrentLoginID.WalletBalance}");
            }
            public static void AddDefaultValues()
            {
                CustomerDetails customer1 = new CustomerDetails(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", DateTime.ParseExact("11/11/1999", "dd/MM/yyyy", null), "ravi@gmail.com");
                CustomerDetails customer2 = new CustomerDetails(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", DateTime.ParseExact("11/11/1999", "dd/MM/yyyy", null), "baskaran@gmail.com");
                customerList.AddRange(new CustomList<CustomerDetails>() { customer1, customer2 });
                Console.WriteLine("CustomerID	|WalletBalance|Name	    |FatherName	  |Gender	|Mobile	   |DOB	 |MailID	|Location");
                foreach (CustomerDetails customer in customerList)
                {
                    Console.WriteLine($"{customer.CustomerID}|{customer.WalletBalance}|{customer.Name,5}|{customer.FatherName,5}|{customer.Gender,5}|{customer.Mobile,5}|{customer.DOB,5}|{customer.MailID,5}|{customer.Location,5}|");
                }

                FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
                FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
                FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
                FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
                FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
                FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
                FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
                FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
                FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
                FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
                FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
                foodList.AddRange(new CustomList<FoodDetails>() { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11 });

                OrderDetails order1 = new OrderDetails("CID1001", 580, DateTime.ParseExact("26/11/2022", "dd/MM/yyyy", null), OrderStatus.Ordered);
                OrderDetails order2 = new OrderDetails("CID1002", 870, DateTime.ParseExact("26/11/2022", "dd/MM/yyyy", null), OrderStatus.Ordered);
                OrderDetails order3 = new OrderDetails("CID1001", 820, DateTime.ParseExact("26/11/2022", "dd/MM/yyyy", null), OrderStatus.Cancelled);
                orderList.AddRange(new CustomList<OrderDetails>() { order1, order1, order3 });

                ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
                ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
                ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
                ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
                ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
                ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
                ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
                ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
                ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
                ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
                itemList.AddRange(new CustomList<ItemDetails>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
                foreach(ItemDetails item in itemList)
                {
                    Console.WriteLine($"{item.ItemID}|{item.OrderID}|{item.FoodID}|{item.PurchaseCount}|{item.PriceOfOrder}");
                }

            }
        }
    }