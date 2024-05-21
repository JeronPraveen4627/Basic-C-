using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum Gender{Male,Female,Transgender}
    public class PersonalDetails
    {
        // Properties: 
        // Name
        // FatherName
        // Gender {Enum - Select, Male, Female, Transgender}
        // Mobile
        // MailID

        public string Name{get;set;}

        public string FatherName{get;set;}

        public Gender Gender{get;set;}

        public string Mobile{get;set;}

        public string MailID{get;set;}

        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=mailID;
        }

    }
}