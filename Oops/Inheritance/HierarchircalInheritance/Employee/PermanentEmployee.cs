using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace Employee
{
    public class PermanentEmployee:SalaryInfo
    {
        public static int s_employee=100;
        public string EmployeeID{get;}
        public string EmployeeType{get;set;}
        public double Salary{get;set;}


        public PermanentEmployee(string employeeType,double salary,double basicSalary,int month)
        {
            EmployeeID="EID"+(++s_employee);
            EmployeeType=employeeType;
            Salary=basicSalary;
            Month=month;

        }

        public void ShowSalary(double amount)
        {
            Salary=amount;
        }
    }
    
}