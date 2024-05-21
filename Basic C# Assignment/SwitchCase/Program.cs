using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
namespace SwitchCase;
class Program
{
 public static void Main(string[] args)
 {
    Console.Write("Enter a number 1 : ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter a number 2 : ");
    int num2 = int.Parse(Console.ReadLine());
    Console.Write(" Enter a Operation need to perform : ");
    char operation = char.Parse(Console.ReadLine());
    switch(operation)
    {
        case '+':
        {
         double  addition = num1+num2;
         Console.WriteLine(addition);
         break; 
        }
        case '-':
        {
          double sub = num1-num2;
         Console.WriteLine(sub);
         break; 
        }
        case '*':
        {
         int multiple = num1*num2;
         Console.WriteLine(multiple);
         break; 
        }
        case '/':
        {
         double division = num1/num2;
         Console.WriteLine(division);
         break; 
        }
        case '%':
        {
         int module = num1%num2;
         Console.WriteLine(module);
         break; 
        }
    }
 }
}
