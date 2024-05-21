using System;
namespace Question4;

class Pprogram{
    public static void Main(string[] args)
    {
        string str=Console.ReadLine();
        string[] str1= str.Split(" ");
        string str3="";
        foreach(string i in str1)
        {
            Console.Write(i);
        }
    }
}