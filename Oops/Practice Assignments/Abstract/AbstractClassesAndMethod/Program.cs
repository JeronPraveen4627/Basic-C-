using System;

namespace AbstractClassesAndMethod;

class Program
{
    public static void Main(string[] args)
    {
        Syncfusion job1=new Syncfusion();
        job1.Name="Dhoni";
        Console.WriteLine(job1.Display());
        Console.WriteLine(job1.Salary(30));

         Employee job2=new Virtusa();
        job2.Name="Praveen";
        Console.WriteLine(job2.Display());
        Console.WriteLine(job2.Salary(30));

    }
}