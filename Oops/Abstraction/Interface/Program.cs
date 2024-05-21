using System;

namespace Interface;

class Program
{
    public static void Main(string[] args)
    {
        
       Square number = new Square();//Class Variable as object
       number.Number=20;
       Console.WriteLine(number.Calculate()); 

       Circle number1 = new Circle();
       number1.Number=5;
       Console.Write(number1.Calculate());
    }
}