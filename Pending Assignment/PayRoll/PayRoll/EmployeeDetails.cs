using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PayRoll
{
    public enum Gender { Male, Female, Transgender }

    public enum Team { Network, Hardware, Developer, Facility }
    public enum Branch { Eymard, Karuna, Madhura }
    public class EmployeeDetails
    {
        private static int s_employeeID=3000;
        public string EmployeeID { get; }
        public string Name { get; set; }

        public string DOB { get; set; }

        public Gender Gender { get; set; }

        public string MobileNumber { get; set; }
        public Branch Branch { get; set; }
        public Team Team { get; set; }


        public EmployeeDetails(string name,string dob,Gender gender,string mobileNumber,Branch branch,Team team)
        {
            EmployeeID="SF"+(++s_employeeID);
            Name=name;
            DOB=dob;
            Gender=gender;
            MobileNumber=mobileNumber;
            Branch=branch;
            Team=team;
        }
    }
}