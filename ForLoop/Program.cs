using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a First Number : ");
        int firstnumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a last number : ");
        int lastnumber = int.Parse(Console.ReadLine());
        int square = 0;

        for (int i= ++firstnumber; firstnumber<lastnumber;firstnumber++)
        {
            square = square + firstnumber*firstnumber;
        }
        Console.WriteLine(square);
    }
}