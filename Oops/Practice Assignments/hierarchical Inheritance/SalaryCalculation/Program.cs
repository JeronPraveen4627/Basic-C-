using System;
namespace SalaryCalculation;
class Program
{
        public static void Main(string[] args)
        {
                SalaryInfo salary1=new SalaryInfo(10000,1);
                TemporaryEmployee employee1=new TemporaryEmployee(salary1.BasicSalary,salary1.Month,"Regular",200,200,100,10000);
                TemporaryEmployee employee2=new TemporaryEmployee(salary1.BasicSalary,salary1.Month,"Regular",400,400,200,20000);
                employee1.CalculateTotalSalary();
                employee2.CalculateTotalSalary();

                PermanentEmployee pemployee1=new PermanentEmployee(salary1.BasicSalary,salary1.Month,"Regular",600,600,300,30000);
                PermanentEmployee pemployee2=new PermanentEmployee(salary1.BasicSalary,salary1.Month,"Regular",600,600,300,30000);
                

        }
}