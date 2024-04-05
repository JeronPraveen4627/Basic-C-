using System;
using System.ComponentModel.DataAnnotations;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Main String : ");
        string main = Console.ReadLine();
        Console.Write("String to be searched : ");
        string search=Console.ReadLine();
        string [] newName = main.Split(search);
        Console.WriteLine(newName.Length-1);
    }
}