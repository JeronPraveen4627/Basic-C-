using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using EmployeePayroll;

namespace EmpolyeePayroll
{
    class Program
    {
        static List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
        public static void Main(string[] args)
        {
            int option;
            do{
                Console.WriteLine("1.Registration\n2.login\n3.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {   string check;
                            do
                            {
                            
                                Console.Write("Enter Your Name  : ");
                                string name=Console.ReadLine();
                                Console.Write("Role : ");
                                string role=Console.ReadLine();
                                Console.Write("Team Name : ");
                                String team = Console.ReadLine();
                                Console.Write("Enter your Location");
                                Location location=Enum.Parse<Location>(Console.ReadLine());
                                Console.Write("Date Of Joining : ");
                                DateTime joinDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                                Console.Write("Number of Working Dates : ");
                                int workingDays = int.Parse(Console.ReadLine());
                                Console.Write("Number Of Leave Taken : ");
                                int LeaveTaken=int.Parse(Console.ReadLine());
                                Console.Write("Gender : ");
                                Gender gender=Enum.Parse<Gender>(Console.ReadLine());

                                EmployeeDetails empolyee=new EmployeeDetails(name, role, team,location,joinDate, workingDays, LeaveTaken, gender);
                                employeeList.Add(empolyee);
                                Console.WriteLine($"Your EmployeeID {empolyee.EmployeeId}");

                            Console.WriteLine("Do you want to create Another User");
                            check=Console.ReadLine();
                            }while(check=="yes");
                        break; 
                    }
                case 2:
                {   Console.Write("Enter your Employee ID : ");
                    string loginId=Console.ReadLine();
                    for(int i=0;i<employeeList.Count;i++)
                    {
                        if(loginId==employeeList[i].EmployeeId)
                        {
                            Console.Write("1.Calculate Salary\n2.Display Details\n3.Exit");
                            int submenu=int.Parse(Console.ReadLine());
                            switch(submenu)
                            {
                                case 1:
                                {
                                    // Console.Write("No number of working : ");
                                    // int leave=int.Parse(Console.ReadLine());
                                    int amount=employeeList[i].CalculateSalary();
                                    Console.WriteLine($"Your Salary: {amount}");
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
            }
        }while(option!=3);
    }
}    
}
