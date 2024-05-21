using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowingStudentDetails
{
    public class StudentInfo:PersonalInfo
    {
        //RegisterNumber, Standard, Branch, AcadamicYear

        public string RegisterNumber{get;}

        public int Standard{get;set;}

        public string Branch{get;set;}

        public int AcadamicYear{get;set;}
    
    public StudentInfo(string registerNumber,string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,int standard,string branch,int acadamicYear):base( name, fatherName, phoneNumber, mailID, dob, gender)
    {
       
        RegisterNumber=registerNumber;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;

    }

    }
}