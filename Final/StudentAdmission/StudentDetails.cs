using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
namespace StudentAdmission
{
    // Enum Declaration
    public enum Gender{Select,Male,Female}
    public class StudentDetails
    {
        /*Properties: 
            a.	StudentID – (AutoGeneration ID – SF3000)
            b.	StudentName
            c.	FatherName
            d.	DOB
            e.	Gender – Enum (Male, Female, Transgender)
            f.	Physics
            g.	Chemistry
            h.	Maths*/

            //Field
            //Static Field
            private static int s_studentID=3000;
            //Properties

            public string StudentID{get;}
            public string StudentName{get; set;}

            public string FatherName{get; set;}

            public DateTime DOB{get; set;}

            public Gender Gender{get; set;}

            public int Physics{get; set;}

            public int Chemistry{get; set;}

             public int Maths{get; set;}

             //Constructor
             public StudentDetails(string studentName,string fatherName, DateTime dob, Gender gender,int physics,int chemistry,int maths)
             {
                //Auto Increment
                s_studentID++;
                StudentID="SF"+s_studentID;
                StudentName=studentName;
                FatherName=fatherName;
                DOB=dob;
                Gender=gender;
                Physics=physics;
                Chemistry=chemistry;
                Maths=maths;
             }


             public StudentDetails(string students)
             {
                //Auto Increment
                string[] value=students.Split(',');
                StudentID=value[0];
                s_studentID=int.Parse(value[0].Remove(0,2));
                StudentName=value[1];
                FatherName=value[2];
                DOB=DateTime.ParseExact(value[3],"dd/MM/yyyy",null);
                Gender=Enum.Parse<Gender>(value[4]);
                Physics=int.Parse(value[5]);
                Chemistry=int.Parse(value[6]);
                Maths=int.Parse(value[7]);
             }
             public double Average()
             {
                int total=Physics+Chemistry+Maths;
                double average=(double)total/3;
                return average;
             }
             public bool CheckEligiblity(double cutOff)
             {
                if(Average()>=cutOff)
                return true;
                else
                return false;
             }

    }
}