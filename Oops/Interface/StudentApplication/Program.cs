using System;
namespace StudentApplication;
class Program
{
    public static void Main(string[] args)
    {
       StudentInfo student1=new StudentInfo("SID1001","Name1","FatherName1","1236549877");
       StudentInfo student2=new StudentInfo("SID1002","Name2","FatherName2","1236549877");
        student1.Display();
        Console.WriteLine();
        student2.Display();
        Console.WriteLine();
        
        EmployeeInfo employee1=new EmployeeInfo("SID1001","Name1","FatherName1");
        EmployeeInfo employee2=new EmployeeInfo("SID1002","Name2","FatherName2");
        employee1.Display();
        Console.WriteLine();
        employee2.Display();
        Console.WriteLine();


    }
}