using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

 
namespace LibraryManagement
{
    
    public class Operation
    {
        static UserDetails CurrentLoginUser;
        
        public  static List<UserDetails> userlist=new List<UserDetails>();
        public  static List<BookDetails> booklist=new List<BookDetails>();
        public  static List<BorrowDetails> borrowlist=new List<BorrowDetails>();
        public static void MainMenu()
      { 
        string mainMenucheck="yes";
        do{
       
        Console.WriteLine("Select Any One Option\n1.UserRegistration\n2.User Login\n3.Exit");
      
        int mainMenuOption=int.Parse(Console.ReadLine());
        switch(mainMenuOption)
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
                mainMenucheck="no";
                Console.WriteLine("Application Ended Successfully");
                break;
            }
        } //Main Menu Switch
        Console.WriteLine();
        // Console.WriteLine("Do you want MainMenu Option : yes/no");
        //  Console.WriteLine();
        // mainMenucheck=Console.ReadLine().ToLower();
       
        }while(mainMenucheck=="yes");
      } //Main Menu Ended 


      public static void Registration()
      {
        //Get Inputs From User
        Console.WriteLine("Now your are in Registration ");
        Console.Write("Enter Your User Name : ");
        string userName=Console.ReadLine();
        Console.Write("Enter Your Gender : ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine());
        Console.Write("Enter your Department : ");
        Department department=Enum.Parse<Department>(Console.ReadLine());
        Console.Write("Enter Your Mobile Number : ");
        long mobileNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter Your MailID : ");
        string mailID = Console.ReadLine();
        Console.Write("Enter Your Wallet Balance amount : ");
        double walletBalance=double.Parse(Console.ReadLine());
        UserDetails user=new UserDetails(userName,gender,department,mobileNumber,mailID,walletBalance);
        userlist.Add(user);
        //Show User ID
        Console.WriteLine($"Your User ID is : {user.UserID}");
      }

      public static void UserLogin()
      {
        Console.Write("Enter your login ID : ");
        string loginID=Console.ReadLine();
        bool flag=true;
        foreach(UserDetails user in userlist)
        {
            if(loginID==user.UserID)
            {   
                flag=false;
                Console.Write("Successfully Login");
                CurrentLoginUser=user;
                SubMenu();

            }
        }
         if(flag)
            {
                Console.WriteLine("Invalid ID");
            }
      }//User Login Ended

      public static void SubMenu()
      {
        string check;
        do{
                
                check="yes";
                Console.WriteLine("Select Opteration need to Perform\n1.Borrow Book\n2.Show Borrowed histroy\n3.Return Books\n4.WalletRecharge\n5.Exit");
                int subMenuOption=int.Parse(Console.ReadLine());
                switch(subMenuOption)
                {
                    case 1: 
                    {
                        BorrowBook();
                        break;
                    }
                    case 2:
                    {
                        ShowBorrowedHistory();
                        break;
                    }
                    case 3:
                    {
                        ReturnBook();
                        break;
                    }
                    case 4:
                    {
                        WalletRecharge();
                        break;
                    }
                    case 5:
                    {
                        check="no";
                        Console.WriteLine("Exit from sub menu");
                        break;
                    }
                }
            }while(check=="yes");// Submenu dowhile Loop ended
        }



    public static void BorrowBook()
    {
        foreach( BookDetails book in booklist)
        {
            Console.WriteLine($"|{book.BookID}|{book.AuthorName}|{book.BookCount}|");
        }
        Console.Write("Enter Book ID to borrow");
            string borrowBookID=Console.ReadLine();
            foreach(BookDetails book in booklist)
            {
                if(book.BookID==borrowBookID)
                Console.WriteLine("Book Borrowed Successfully");
            }
    }


    public static void ShowBorrowedHistory()
    {

    } 

    public static void ReturnBook()
    {

    }

    public static void WalletRecharge()
    {

    }
      public static void AddDefaultData()
      {
        UserDetails user1=new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com",100);
        UserDetails user2=new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com",150);
        userlist.Add(user1);
        userlist.Add(user2);
       

        BookDetails book1=new BookDetails("C#","Author1",3);
        BookDetails book2=new BookDetails("HTML","Author2",5);
        BookDetails book3=new BookDetails("CSS","Author1",3);
        BookDetails book4=new BookDetails("JS","Author1",3);
        BookDetails book5=new BookDetails("TS","Author2",2);
        booklist.Add(book1);
        booklist.Add(book2);
        booklist.Add(book3);
        booklist.Add(book4);
        booklist.Add(book5);
  


        BorrowDetails borrow1=new BorrowDetails("BID1001","SF3001",DateTime.ParseExact("10/09/2023","dd/MM/yyyy",null),2,Status.Borrowed,0);
        BorrowDetails borrow2=new BorrowDetails("BID1003","SF3001",DateTime.ParseExact("12/09/2023","dd/MM/yyyy",null),1,Status.Borrowed,0);
        BorrowDetails borrow3=new BorrowDetails("BID1004","SF3001",DateTime.ParseExact("14/09/2023","dd/MM/yyyy",null),1,Status.Returned,16);
        BorrowDetails borrow4=new BorrowDetails("BID1002","SF3002",DateTime.ParseExact("11/09/2023","dd/MM/yyyy",null),2,Status.Borrowed,0);
        BorrowDetails borrow5=new BorrowDetails("BID1005","SF3002",DateTime.ParseExact("09/09/2023","dd/MM/yyyy",null),1,Status.Returned,20);
        borrowlist.Add(borrow1);
        borrowlist.Add(borrow2);
        borrowlist.Add(borrow3);
        borrowlist.Add(borrow4);
        borrowlist.Add(borrow5);
        
        foreach(UserDetails user in userlist)
        {
            Console.WriteLine($"|{user.UserID}|{user.UserName}|{user.Gender}|{user.Department}|{user.MobileNumber}|{user.MailID}|{user.WalletBalance,5}|");
        }
        Console.WriteLine();

        foreach(BookDetails book in booklist)
        {
            Console.WriteLine($"|{book.BookID}|{book.AuthorName}|{book.BookCount,5}|");
        }
        Console.WriteLine();
         foreach(BorrowDetails borrow in borrowlist)
        {
            Console.WriteLine($"|{borrow.BookID}|{borrow.UserID}|{borrow.BorrowedDate}|{borrow.BorrowBookCount}|{borrow.Status,3}|{borrow.PaidFineAmount,5}|");
        }
        Console.WriteLine();
     }
      
    }
}