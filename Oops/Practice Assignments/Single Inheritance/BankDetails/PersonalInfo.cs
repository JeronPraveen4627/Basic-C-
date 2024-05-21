using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails
{
    public class PersonalInfo
    {
        //Name, FatherName, Phone, Mail, DOB, Gender

        public string Name{get; set;}

        public string FatherName{get;set;}

        public long Phone{get; set;}

        public string MailID{get; set;}

        public DateTime DOB{get; set;}

        public string Gender{get; set;}

        public PersonalInfo(string name,string fatherName,long phone,string mailID,DateTime dob,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone= phone;
            MailID=mailID;
            DOB= dob;
            Gender=gender;
        }
    }
}