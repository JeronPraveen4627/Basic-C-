using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class TemporaryEmployee:SalaryInfo
    {
        // Properties: EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
         private static int s_temployeeID=200;

        public string TemployeeID{get;}

        public string TemployeeType{get;set;}

        public double TemployeeDA{get;set;}

        public double TemployeeHRA{get;set;}

        public double TemployeePF{get;set;}

        public double TTotalSalary{get;set;}

        public TemporaryEmployee(double basicSalary,int month,string temployeetype,double temployeeDA,double temployeeHRA, double temployeePF,double ttotalasalary ):base(basicSalary,month)
        {
            TemployeeID="TID"+(++s_temployeeID);
            TemployeeType=temployeetype;
            TemployeeDA=temployeeDA;
            TemployeeHRA=temployeeHRA;
            TemployeePF=temployeePF;
            TTotalSalary=ttotalasalary;

        }

    public  void CalculateTotalSalary()
   {
        //Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
        TTotalSalary=BasicSalary+TemployeeDA+TemployeeHRA-TemployeePF;
        Console.WriteLine($"Total Salary: {TTotalSalary}");
   }
    }
}