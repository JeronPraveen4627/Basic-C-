using System;
namespace Application;//File Scope Namespace
class Program
{
    public static void Main(string[] args)
    {
        //Calling default Data
        Operations.AddDefaultData();

        Operations.MainMenu();
    }
}