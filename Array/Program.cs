using System;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        string[] arr = new string[5]{"Praveen","Jeron","Dhoni","liam","barath"};
        foreach(string i in arr)
        {
            Console.WriteLine(i);
        }
        Console.Write("Enter a Name to search : ");
        String name = Console.ReadLine();
        int j=0;
        foreach(string i in arr)
        {
            if(i==name)
            {
                Console.WriteLine("The name is present in array");
                break;
            }
            else if(j==arr.Length-1 && i!= name)
            {
                    Console.WriteLine("The name is not present in array");
                    
            }
            j++;
        }
    }
}