using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
namespace Armstrong;
class Program
{
    public static void Main(string[] args)
    {
        int i,r,sum=0,div;
        int number=int.Parse(Console.ReadLine());
        for(i=1;i<number;i++)
        {
            while(i>0)
            {
                r=i%10;
                sum=sum+(r*r*r);
                div=i/10;
            }
            if(sum==i)
            Console.WriteLine(sum);
        }

    }
}

