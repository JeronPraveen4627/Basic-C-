using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayRoll
{
    public  class Operation
    {
         
       public static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
       public static List<AttendanceDetails> attendanceList=new List<AttendanceDetails>();
        public static void MainMenu()
        {
             Console.WriteLine("************************* Payroll Management System *************************");
            string mainChoice="yes";
            do{
            //Need to show Main Menu option
            Console.WriteLine("1.Employee Registration\n2.Employee Login\n3.Exit");
            //need to get input from user
            Console.Write("Select an option : ");
            int mainOption=int.Parse(Console.ReadLine());
            //Create Main Menu Structure
            switch(mainOption)
            {
               case 1:
               {
                Console.WriteLine("******************Employee Registration******************");
                EmployeeRegistration();
                
                break;
               } 
               case 2:
               {
                Console.WriteLine("******************Employee Login ******************");
                EmployeeLogin();
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


       public static void EmployeeRegistration()
        {

            Console.Write("Enter your Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter Your DOB: ");
            string dob=Console.ReadLine();
            Console.Write("Enter your Gender: ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine());
            Console.Write("Enter your Phone Number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter your Branch: ");
            Branch branch=Enum.Parse<Branch>(Console.ReadLine());
            Console.Write("Enter your Team: ");
            Team team=Enum.Parse<Team>(Console.ReadLine());
            EmployeeDetails employee=new EmployeeDetails(name,dob,gender,phoneNumber,branch,team);
            //Need to add in the list
            employeeList.Add(employee);
            //Need to Display conformation message and ID
            Console.WriteLine($"Registration successfully completed Your ID is : {employee.EmployeeID}");

        }

        public static void EmployeeLogin()
        {
            Console.WriteLine("Enter Your CustomerID: ");
            string login=Console.ReadLine();
            bool flag=true;
            foreach(EmployeeDetails employee in employeeList)
            {
                if(login.Equals(employee.EmployeeID))
                {
                    flag=false;
                    CurrentLoggedIn=employee;
                    Console.WriteLine("Login Successfully");
                    SubMenu();
                }
            
            }
            if(flag)
            {
                Console.WriteLine("Invalid ID");
            }
        }


    }
}