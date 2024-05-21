using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class PersonalInfo
    {
        public string Name{get;set;}

        public string FatherName{get;set;}

        public DateTime DOB{get;set;}

        public long PhoneNumber{get;set;}

        public string Gender{get;set;}

        public string MailID{get;set;}

        public PersonalInfo(string name, string fatherName,long phoneNumber,string gender,string mailID,DateTime dob)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            Gender=gender;
            MailID=mailID;
            DOB=dob;

        }


    }
}