using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class PermanentEmployee:SalaryInfo
    {
        //Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary

        private static int s_employeeID=100;

        public string EmployeeID{get;}

        public string EmployeeType{get;set;}

        public double EmployeeDA{get;set;}

        public double EmployeeHRA{get;set;}

        public double EmployeePF{get;set;}

        public double TotalSalary{get;set;}

         public PermanentEmployee(double basicSalary,int month,string employeetype,double employeeDA,double employeeHRA, double employeePF,double totalasalary ):base(basicSalary,month)
        {
            EmployeeID="PID"+(++s_employeeID);
            EmployeeType=employeetype;
            EmployeeDA=employeeDA;
            EmployeeHRA=employeeHRA;
            EmployeePF=employeePF;
            TotalSalary=totalasalary;

        }

   public  void CalculateTotalSalary()
   {
        //Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
        TotalSalary=BasicSalary+EmployeeDA+EmployeeHRA-EmployeePF;
        Console.WriteLine($"Total Salary: {TotalSalary}");
   }

   }


}