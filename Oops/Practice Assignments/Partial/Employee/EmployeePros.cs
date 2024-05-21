using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee
{

    public partial class EmployeeInfo
    {
        private static int s_employeeID = 100;
        public string EmployeeID { get; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public string DOB { get; set; }

        public string Mobile { get; set; }

    }

}