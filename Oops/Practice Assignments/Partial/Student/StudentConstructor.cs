using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        public StudentInfo(string name,string gender,DateTime dob,string phoneNumber,int physics,int chem,int maths){
        StudentID= "SID"+(++s_studentID);
        StudentName=name;
        Gender=gender;
        DOB=dob;
        PhoneNumber=phoneNumber;
        Physics=physics;
        Chemistry=chem;
        Maths=maths; 
    
    }
    }
}