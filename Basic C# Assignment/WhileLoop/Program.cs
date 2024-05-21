using System;
using System.Globalization;
namespace WhileLoop;// File SCoped namespace

    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
    

            Console.WriteLine();

            Console.WriteLine("Exercise 2 :");
            Console.Write("Enter the valid number : ");
            bool isvalid = int.TryParse(Console.ReadLine(), out int num);
            while(!isvalid)
            {    
                Console.Write("Invalid Input, Enter the number again : ");
                isvalid = int.TryParse(Console.ReadLine(), out num);
            }
            Console.WriteLine(num);
        }
    }
