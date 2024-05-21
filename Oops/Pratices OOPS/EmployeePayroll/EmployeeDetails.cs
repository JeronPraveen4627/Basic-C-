using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public enum Location{Chennai,Bangalore}
public enum Gender{Male,Female}

namespace EmployeePayroll
{
    public class EmployeeDetails
    {
        //field
        private static int s_employeeId=1000;

        //Properties
        public string EmployeeId{get;}
        public string EmployeeName{get; set;}
        
        public string Role{get; set;}

        public string TeamName{get; set;}
        public Location WorkingLocation{get; set;}
        public DateTime JoiningDate{get; set;}

        public int WorkingDays{get; set;}

        public int Leave{get; set;}

        public Gender Gender{get; set;}

        public EmployeeDetails(string name,string role,string team, Location location, DateTime Joining, int working, int LeaveTaken, Gender gender)
        {
          s_employeeId++;
          EmployeeId="SF"+s_employeeId;
          EmployeeName=name;
          Role=role;
          TeamName=team;
          WorkingLocation=location;
          JoiningDate=Joining;
          WorkingDays=working;
          Leave=LeaveTaken;
          Gender=gender;

        }
        public int CalculateSalary()
        {
           return (WorkingDays-Leave)*500;
        }

    }
}