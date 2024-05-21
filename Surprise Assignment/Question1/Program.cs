using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int size=int.Parse(Console.ReadLine());
        int[] arr=new int[size];
        for(int i=0;i<size;i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        int[] arr1=new int[size]; 
        int j=0;
        for(int i=0;i<size-1;i++)
        { 
            if(arr[i]<arr[i+1]){
            for(int k=i+1;k<size;k++){
            if(arr[i]<arr[k])
            {
                continue;
            }
            if(arr[i]>arr[k])
            {
                arr1[j]=arr[i];
                j++;
                break;
            }
            }
            

            }
        }
        for(int i=0;i<j;i++)
        {
            Console.Write($"{arr1[i] } ");
        }
    }
}