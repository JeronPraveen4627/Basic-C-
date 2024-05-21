using System;
using System.Transactions;
namespace Program;
class TypeConversion
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter your Age : ");
        int age = int.Parse(Console.ReadLine()); 
        Console.Write("Enter Mark of Subject 1 : ");
        float subject1 = float.Parse(Console.ReadLine());
        Console.Write("Enter Mark of Subject 2 : ");
        float subject2 = float.Parse(Console.ReadLine());
        Console.Write("Enter Mark of Subject 3 : ");
        float subject3 = float.Parse(Console.ReadLine());
        float total = subject1+subject2+subject3;
        float average = total/3;
        Console.Write("Enter Grade : ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("Enter Phone Number : ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id : ");
        string mailid = Console.ReadLine();

        Console.WriteLine("Trainee Details : ");
        Console.WriteLine($"Name : {name}");
        Console.WriteLine($"Age :{age}");
        Console.WriteLine($"Mobile : {number}");
        Console.WriteLine($"Mark 1 : {subject1}");
        Console.WriteLine($"Mark 2 : {subject2}");
        Console.WriteLine($"Mark 3 : {subject3}");
        Console.WriteLine($"Total : {total}");
        Console.WriteLine($"Average : {average}");
        Console.WriteLine($"Grade : {grade}");
        Console.WriteLine($"Mail ID : {mailid}");


    }
}