using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowingStudentDetails
{
    public class PersonalInfo
    {
      //  Name, FatherName,Phone,Mail, dob,Gender

      public string Name{get; set;}

      public string FatherName{get; set;}

      public long PhoneNumber{get;set;}

      public string MailID{get; set;}

      public DateTime DOB{get;set;}

      public string Gender{get;set;}

      public PersonalInfo(string name,string fatherName, long phoneNumber, string mailID, DateTime dob, string gender)
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