using System;
using System.Xml.XPath;
namespace Holiday;

class Program
{
    public static void Main(string[] args)
    {
        DateTime holidayDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        int size = int.Parse(Console.ReadLine());
        DateTime[] arr=new DateTime[size];
        bool check=false;


        for(int i=0;i<size;i++)
        {
            arr[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        }


        string date=holidayDate.DayOfWeek.ToString();
        date=date.ToLower();


         if(date=="sunday" || date=="Saturday")
        {
            check=true;
        }


        //int result=0;
        for (int i=0;i<size;i++)
        {
            if(holidayDate==arr[i])
            {
                check=true;
            }
        }
     
        if(check)
        {
            Console.WriteLine("Holiday:-)");
        }
        else
        {

            Console.WriteLine("Not an Holiday:-(");
        }


    }
}