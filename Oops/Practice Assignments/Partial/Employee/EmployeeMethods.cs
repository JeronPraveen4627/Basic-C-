using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{

    public partial class EmployeeInfo
    {
        public void Display()
        {
            Console.WriteLine($"Student ID : {EmployeeID}");
            Console.WriteLine($"Student Name :{Name}");
            Console.WriteLine($"Gender :{Gender}");
            Console.WriteLine($"DOB :{DOB}");
            Console.WriteLine($"Mobile :{Mobile}");

        }
    }
}
