using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace QwickFoodz
{
    public enum Gender{Male,Female,Transgender}
    public class PersonalDetails
    {
     
     public string Name{get;set;}

     public string FatherName{get;set;}

     public Gender Gender{get;set;}

     public string Mobile {get;set;}

     public DateTime DOB{get;set;}

     public string MailID{get;set;}

     public string Location{get;set;}

    public PersonalDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID )
    {
        Name=name;
        FatherName=fatherName;
        Gender=gender;
        Mobile=mobile;
        DOB=dob;
        MailID=mailID;
        Location="Chennai";

    }

    }
}