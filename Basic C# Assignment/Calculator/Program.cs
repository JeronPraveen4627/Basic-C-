using System;
using System.ComponentModel;
namespace Calculator;
class Program{
    public static void Main(string[] args)
    {   
        string choice;
        do{
        Console.WriteLine("Enter two number: ");
        int number1 =int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an option\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Add(number1,number2);    
                break;
            }
            case 2:
            {
                Sub(number1,number2);    
                break;
            }
            case 3:
            {
                Mul(number1,number2);
                break;
            }
            case 4:
            {
                Div(number1,number2);
                break;
            }
        }
        Console.WriteLine("Do you want to continue : yes/no");
        choice = Console.ReadLine();

        }while(choice=="yes");
        static void Add(int a, int b){
            Console.WriteLine($"Add : {a+b}");
        }
        static void Sub(int a, int b){
            Console.WriteLine($"Sub : {a-b}");
        }
        static void Mul(int a, int b){
            Console.WriteLine($"Mul : {a*b}");
        }
        static void Div(int a, int b){
            Console.WriteLine($"Div : {a/b}");
        }

    }
}
