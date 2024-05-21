using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission
{
    public class FileHandling
    {
        public static void create()
        {
             if(!Directory.Exists("StudentAdmission"))
            {
                Console.WriteLine("Creating a Folder");
                Directory.CreateDirectory("StudentAdmission");
            }
            if(!File.Exists("StudentAdmission/AdmissionDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("StudentAdmission/AdmissionDetails.csv").Close();
            };
            if(!File.Exists("StudentAdmission/DepartmentDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("StudentAdmission/DepartmentDetails.csv").Close();
            };
            if(!File.Exists("StudentAdmission/StudentDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("StudentAdmission/StudentDetails.csv").Close();
            };


        }
            public static void WriteToCSV()
        {
            string[] students=new string[Operations.studentList.Count];
            for(int i=0;i<Operations.studentList.Count;i++)
            {
                students[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].Physics+","+Operations.studentList[i].Chemistry+","+Operations.studentList[i].Maths;
            }
            File.WriteAllLines("StudentAdmission/AdmissionDetails.csv",students);

            string[] department=new string[Operations.departmentList.Count];
            for(int i=0;i<Operations.departmentList.Count;i++)
            {
                department[i]=Operations.departmentList[i].DepartmentID+","+Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats;
            }
            File.AppendAllLines("StudentAdmission/DepartmentDetails.csv",department);
        }

        public static void ReadFromCSV()
        {
            string[] students=File.ReadAllLines("StudentAdmission/AdmissionDetails.csv");
            foreach(string student in students)
            {
                StudentDetails student1=new StudentDetails(student);
                Operations.studentList.Add(student1);
            }
        }    
    }
}

        
