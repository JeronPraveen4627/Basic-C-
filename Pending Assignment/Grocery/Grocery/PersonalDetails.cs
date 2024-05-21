using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public class PersonalDetails
    {

        /// <summary>
        /// This property used to get input from PersonlDetails object
        /// </summary>
        /// <value></value>    
        public string Name{get;set;}

        public string FatherName{get;set;}

        public string Gender{get;set;}

        public string Mobile{get;set;}

        public DateTime DOB{get;set;}

        public string MailID{get;set;}

        public PersonalDetails(string name, string fatherName,string gender, string mobile,DateTime dob,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;

        }
    }
}