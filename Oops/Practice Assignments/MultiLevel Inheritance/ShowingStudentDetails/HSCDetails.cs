using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShowingStudentDetails
{
    public  class HSCDetails:StudentDetails
    {
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int TotalMark{get;set;}
        public double PercentageMarks{get;set;}

        public HSCDetails(string name,string fatherName, long phoneNumber, string mailID, DateTime dob, string gender,string registerNumber,string standard,string branch,string acadamicYear,int physics,int chemistry,int maths):base(name, fatherName,  phoneNumber,  mailID, dob, gender,registerNumber, standard, branch, acadamicYear)
        {
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        public void GetMarks()
        {
            Console.WriteLine("Physics Mark: ");
            Physics=int.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry Marks: ");
             Chemistry=int.Parse(Console.ReadLine());
            Console.WriteLine("Maths mark: ");
             Maths=int.Parse(Console.ReadLine());
        }

        public  void Total()
        {
            TotalMark=Physics+Chemistry+Maths;
        }

        public void Percentage()
        {
             PercentageMarks=TotalMark/3*100;
        }
        public void ShowMarkSheet()
        {
            Console.WriteLine($"Mark Sheet: {RegisterNumber}");
            Console.WriteLine($"Physic Mark: {Physics}");
            Console.WriteLine($"Chemistry Mark: {Chemistry}");
            Console.WriteLine($"Maths Mark: {Maths}");
            Console.WriteLine($"Total Mark: {TotalMark}");
            Console.WriteLine($"Percentage: {PercentageMarks}");
        }



        
    }
}