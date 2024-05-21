using System;
namespace OnlineMedical;

class Program
{
    public static void Main(string[] args)
    {
        
        FileHandling.Create();
        //Operation.AddDefaultValue();
        FileHandling.ReadFromCSV();
        Operation.MainMenu();
        
        FileHandling.WriteToCSV();
        
        
    }
}