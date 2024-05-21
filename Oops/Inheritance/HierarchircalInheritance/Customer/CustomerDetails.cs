using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchircalInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=2000;
        public string CustomerID{get;}

        public int Balance{get; set;}

        public CustomerDetails(string userID,string userName, string fatherName,Gender gender,long phoneNumber,int balance):base(userID,userName,  fatherName,gender,phoneNumber)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            Balance=balance;
        }
    }
}