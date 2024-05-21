using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class DepartmentDetails
    {
         /*Properties: 
            a.	DepartmentID – (AutoIncrement - DID101)
            b.	DepartmentName
            c.	NumberOfSeats
            */

            //Field
            //Static Field
            private static int s_departmentID=100;
            //Properties

            public string DepartmentID{get;}
            public string DepartmentName{get; set;}

            public int NumberOfSeats{get; set;}

             //Constructor
             public DepartmentDetails(string departmentName,int numberOfSeats)
             {
                //Auto Increment
                s_departmentID++;
                DepartmentID="DID"+s_departmentID;
                DepartmentName=departmentName;
                NumberOfSeats=numberOfSeats;
             }
    }
}