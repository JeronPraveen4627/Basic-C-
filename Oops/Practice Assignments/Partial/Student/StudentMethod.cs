using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        public void CalculateTotal()
        {
           Total = Physics+Chemistry+Maths;
        }

        public void CalculatePercentage()
        {
            Percentage=(Total*100)/300;
        } 
        public void Display()
        {
            Console.WriteLine($"Student ID : {StudentID}");
            Console.WriteLine($"Name : {StudentName}");
            Console.WriteLine($"DOB : {DOB}");
            Console.WriteLine($"Gender : {Gender}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
             Console.WriteLine($"Physics : {Physics}");
              Console.WriteLine($"Chemistry : {Chemistry}");
             Console.WriteLine($"Maths : {Maths}");
             Console.WriteLine($"Total : {Total}");
              Console.WriteLine($"Percentage : {Percentage}");
        }
    }
}