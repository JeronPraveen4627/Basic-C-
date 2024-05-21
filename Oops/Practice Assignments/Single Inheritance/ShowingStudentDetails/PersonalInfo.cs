using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowingStudentDetails
{
    public enum Gender{Male,Female,Transgender}
    public class PersonalInfo
    {
        //Properties
        public string Name{get; set;}

        public string FatherName{get; set;}

        public long PhoneNumber{get;set;}

        public string MailID{get; set;}

        public DateTime DOB{get; set;}

        public Gender Gender{get; set;}

        //Cons
        public PersonalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            Gender=gender;
        }


    }
}