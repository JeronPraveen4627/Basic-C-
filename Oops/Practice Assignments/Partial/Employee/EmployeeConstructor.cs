using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string name, string gender, string dob, string mobile)
        {
            EmployeeID = "EID" + (++s_employeeID);
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}