using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{       
     // Enum Declaration
    public enum AdmissionStatus{Select, Admitted, Cancelled}
    public class AdmissionDetails
    {
        //Field
        //Static Field
         private static  int s_admissionID=1001;
        /*Properties:
        a.	AdmissionID – (Auto Increment ID - AID1001)
        b.	StudentID
        c.	DepartmentID
        d.	AdmissionDate
        e.	AdmissionStatus – Enum- (Select, Admitted, Cancelled)
        */
            
            public string AdmissionID{get;}
            public string StudentID{get; set;}

            public string DepartmentID{get; set;}

            public DateTime AdmissionDate{get; set;}

            public AdmissionStatus AdmissionStatus{get; set;}

            //Constructor
            public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
            {
                //Auto Increment
                s_admissionID++;
                AdmissionID="AID"+s_admissionID;
                StudentID=studentID;
                DepartmentID=departmentID;
                AdmissionDate=admissionDate;
                AdmissionStatus=admissionStatus;
            }

           
    }
}