using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultiInheritance;

namespace MultiInheritance
{
    public class EmployeeDetails: StudentDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID{get; set;}

        public string Designation{get; set;}

        public EmployeeDetails(string studendId,string userID,string userName, string fatherName,Gender gender,long phoneNumber,int standard, int yearOfJoining,string designation):base( studendId, userID, userName,  fatherName,gender, phoneNumber,standard, yearOfJoining)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Designation=designation;

        }
    }
}