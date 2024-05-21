using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Inside;

class Program
{
    public static void Main(string[] args)
    {
        
        First sample =new First();
        Console.WriteLine(sample.PrivateOut);
        Console.WriteLine(sample.PublicNumber);
       // Console.WriteLine(sample.Protect);

        Second sample1=new Second();
        Console.WriteLine(sample1.ProtectedNumberOut);
        Console.WriteLine(sample1.InternalProtected);


    }
}