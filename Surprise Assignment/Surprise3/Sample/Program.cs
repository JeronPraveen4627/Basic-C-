using System;
namespace Sample;
class Program
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        string str=Console.ReadLine();
        string[] str1=str.Split(' ');
        int[] arr=new int[size];
        for(int i=0;i<size;i++)
        {
            arr[i]=int.Parse(str1[i]);
        }
        int[] arr1=new int[size-1];
        for(int i=0;i<size-1;i++)
        {
            if(arr[i]>arr[i+1])
            {
                arr1[i]=arr[i];
            }
            else
            {
                arr1[i]=arr[i+1];
            }
        }

        for(int i=0;i<arr1.Length;i++)
        {
            if(i==arr1.Length)
            Console.Write(arr1[i]);
            else
            {
                Console.Write($"{arr1[i]} ");
            }
        }
    }
}    
