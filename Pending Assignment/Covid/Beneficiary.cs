using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Covid
{
    public enum Gender{Male,Female, Other}
    public class Beneficiary
    {
        //Properties:
        // a.	Registration Number (Auto Incremented BID1001)
        // b.	Name
        // c.	Age
        // d.	Gender (Enum [Male, Female, Others])
        // e.	Mobile Number

        private static int s_registrationNumber=1000;

        public string RegistrationNumber{get;set;}

        public string Name{get;set;}

        public Gender Gender{get;set;}

        public string MobileNumber{get;set;}

        public Beneficiary(string name,Gender gender,string mobileNumber)
        {
            RegistrationNumber="BID"+(++s_registrationNumber);
            Name=name;
            Gender=gender;
            MobileNumber=mobileNumber;
        }

    }
}