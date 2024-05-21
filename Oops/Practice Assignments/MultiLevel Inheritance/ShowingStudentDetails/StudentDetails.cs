using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowingStudentDetails
{
    public class StudentDetails:PersonalInfo
    {
       
        //private static int 
        public string RegisterNumber{get;set;}
        public string Standard{get;set;}

        public string Branch{get;set;}
        public string AcadamicYear{get;set;}

        public StudentDetails(string name,string fatherName, long phoneNumber, string mailID, DateTime dob, string gender,string registerNumber,string standard,string branch,string acadamicYear):base(name, fatherName, phoneNumber,  mailID, dob,  gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
        
        public void GetStudentInfo()
        {
            Console.WriteLine("Enter your Register Name: ");
             RegisterNumber=Console.ReadLine();
            Console.WriteLine("Enter Standard: ");
             Standard=Console.ReadLine();
            Console.WriteLine("Enter your Branch: ");
             Branch=Console.ReadLine();
            Console.WriteLine("Enter your Acadamic Year: ");
             AcadamicYear=Console.ReadLine();

        }

        public  void ShowInfo()
        {
           Console.WriteLine($"Register Number: {RegisterNumber}");
           Console.WriteLine($"Standard: {Standard}");
           Console.WriteLine($"Branch: {Branch}");
           Console.WriteLine($" Acadamic Year: {AcadamicYear}");
        }

    }
}