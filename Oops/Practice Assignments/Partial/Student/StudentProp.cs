using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        private static int s_studentID=1000;

        public string StudentID{get;}

        public string StudentName{get;set;}
        public string PhoneNumber{get;set;}
        public DateTime DOB{get;set;}

        public string Gender{get;set;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}
        public int Total{get;set;}

        public int Percentage{get;set;}
    }
}