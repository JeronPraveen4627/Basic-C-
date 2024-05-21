using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class EmployeeInfo:IDisplayInfo
    {
        public string EmployeeID{get;set;}

        public string Name{get;set;}

        public string FatherName{get;set;}

        public EmployeeInfo(string employeeID,string name,string fatherName)
        {
            EmployeeID=employeeID;
            Name=name;
            FatherName=fatherName;
        }

        public void Display()
        {
            Console.WriteLine(EmployeeID);
            Console.WriteLine(Name);
            Console.WriteLine(FatherName);
        }

        


    }
}