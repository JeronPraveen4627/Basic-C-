using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        public PersonalDetails()
        {
            //Constructor class
            PersonalDetails personal=new PersonalDetails();
            personal.DOB=new DateTime(2001,02,05);
        }
    }
}