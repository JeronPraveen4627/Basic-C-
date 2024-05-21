using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=3000;

        public string PrincipalID{get;}

        public string Qualification{get;set;}

        public int YearOfExp{get;set;}

        public int DateOfJoining{get;set;} 

        public PrincipalInfo(string name, string fatherName,long phoneNumber,string gender,string mailID,DateTime dob,string qualification,int yearOfExp,int dateOfJoining):base( name,  fatherName, phoneNumber, gender, mailID, dob) 
        {
            PrincipalID="PID"+(++s_principalID);
            Qualification=qualification;
            YearOfExp=yearOfExp;
            DateOfJoining=dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Principal ID: {PrincipalID}\nPrincipal Name: {Name}\nFather Name: {FatherName}\nPhone: {PhoneNumber}\nMail ID : {MailID}\nDOB: {DOB}\nGender: {Gender} ");
            Console.WriteLine($"Qualification: {Qualification}\nYear of Experience: {YearOfExp}\nDate of joining: {DateOfJoining}");
        }
    }
}