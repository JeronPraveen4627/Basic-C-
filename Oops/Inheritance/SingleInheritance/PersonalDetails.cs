using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SingleInheritance
{
    public enum Gender{Male,Female,Transgender}
    public class PersonalDetails
    {   
        private static int s_userID=100;

        public string UserID{get;}
        public string UserName{get; set;}

        public string FatherName{get; set;}

        public Gender Gender{get; set;}

        public long PhoneNumber{get; set;}


        public PersonalDetails(string userName, string fatherName,Gender gender,long phoneNumber)
        {
            s_userID++;
            UserID="SF"+s_userID;
            UserName=userName;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }

         public PersonalDetails(string userID,string userName, string fatherName,Gender gender,long phoneNumber)
        {
            UserID=userID;
            UserName=userName;
            FatherName=fatherName;
            Gender=gender;
            PhoneNumber=phoneNumber;
        }

    }
}