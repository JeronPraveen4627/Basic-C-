using System;
namespace DateTest;
class Program
{
    public static void Main(string[] args)
    {
    DateTime date = new DateTime(2021,8,10,10,40,32);
    Console.WriteLine($"Year : {date.ToString("yyyy")}");
    Console.WriteLine($"Month : {date.ToString("MM")}");
    Console.WriteLine($"Day :{date.ToString("dd")}");
    Console.WriteLine($"Hours :{date.ToString("HH")}");
    Console.WriteLine($"Mintues : {date.ToString("mm")}");
    Console.WriteLine($"Seconds : {date.ToString("ss")}");
    
    string strDate = date.ToString("yyyy MM dd hh mm ss tt");
    
    string[] reverseDate = strDate.Split(" ");

    for(int i = reverseDate.Length-1;i>=0;i--)
    {
        Console.Write(reverseDate[i]);
        if(i!=0)
        {
            Console.Write(" ");
        }

    }
    
    Console.Write("\nEnter date in Format : yyyy/MM/dd hh:mm:ss tt: ");
    DateTime userdate= DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
    Console.Write($"{userdate.Year} {userdate.Month} {userdate.Day}");
    }
}