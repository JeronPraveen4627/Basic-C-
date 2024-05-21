using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace MultiInheritance
{
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=200;

        public string StudentID{get;}


        public int Standard{get; set;}

        public int YearOfJoining{get; set;}

        public StudentDetails(string userID,string userName, string fatherName,Gender gender,long phoneNumber,int standard, int yearOfJoining):base(userID,userName,  fatherName, gender,phoneNumber)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Standard=standard;
            YearOfJoining=yearOfJoining;

        }

          public StudentDetails(string studendId,string userID,string userName, string fatherName,Gender gender,long phoneNumber,int standard, int yearOfJoining):base(userID,userName,  fatherName, gender,phoneNumber)
        {
           
            StudentID=studendId;
            Standard=standard;
            YearOfJoining=yearOfJoining;

        }
    }
}