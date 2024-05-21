using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class Teacher:PersonalInfo
    {
        private static int s_teacherID=100;

        public string TeacherID{get;}
        public string Department{get;set;}

        public string SubjectTeaching{get;set;}

        public string Qualification{get;set;}

        public int YearOfExp{get;set;}

        public int DateOfJoining{get;set;}


        public Teacher(string name, string fatherName,long phoneNumber,string gender,DateTime dob,string mailID,string department,string subjectTeaching,string qualification,int yearOfExp,int dateOfJoining):base(name,fatherName,phoneNumber,gender,mailID,dob)
        {
            TeacherID="TID"+(++s_teacherID);
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExp=yearOfExp;
            DateOfJoining=dateOfJoining;
        }   
        public void ShowDetails()
        {
            Console.WriteLine($"Teacher ID: {TeacherID}\nTeacher Name: {Name}\nFather Name: {FatherName}\nPhone: {PhoneNumber}\nMail ID : {MailID}\nDOB: {DOB}\nGender: {Gender}");
            Console.WriteLine($"Qualification: {Qualification}\nYear of Experience: {YearOfExp}\nDate of Joining: {DateOfJoining}");
        }

    }
}