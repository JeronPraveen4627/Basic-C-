using System;
namespace ByType;
class Program
{
    public static void Main(string[] args)
    {
        //Add Method to add integer
        int result=Add(1,2);
        double result2=Add(1,2);
        string result1=Add("jer","on");
        Console.WriteLine(result2);
    }
    public static int Add(int a, int b)
    {
        return a+b;
    }

    public static string Add(string A, string B)
    {
        return A+B;
    }
}