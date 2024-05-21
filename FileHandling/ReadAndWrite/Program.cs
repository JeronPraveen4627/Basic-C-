using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace ReadAndWrite;

class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Creating a Folder...");
            Directory.CreateDirectory("TestFolder");
        }
        if(!File.Exists("TestFolder/data1.csv"))
        {
            Console.WriteLine("Creating a csv file...");
            File.Create("TestFolder/data1.csv");
        }
        if(!File.Exists("TestFolder/myText.json"))
        {
            Console.WriteLine("Creating a json file...");
            File.Create("TestFolder/myText.json");
        }


        List<StudentDetails> studentList=new List<StudentDetails>();

        studentList.Add(new StudentDetails(){Name="Jeron",FatherName="Sivaraman",PhoneNumber="9685748596",DOB=new DateTime(2001,02,05),TotalMark=450});
        studentList.Add(new StudentDetails(){Name="ICC Trophy",FatherName="Dhoni",PhoneNumber="9988774455",DOB=new DateTime(2011,04,04),TotalMark=500});
        studentList.Add(new StudentDetails(){Name="Pakistan",FatherName="Kohli",PhoneNumber="9988774455",DOB=new DateTime(2008,04,01),TotalMark=450});

        WriteToCSV(studentList);
        ReadCSV();
        WriteToCSV(studentList);
        ReadJson();
        
        static void WriteToCSV(List<StudentDetails> studentList)
        {
                StreamWriter sw=new StreamWriter("TestFolder/data1.csv");
                foreach(StudentDetails student in studentList)
                {
                    string Line=student.Name+"|"+student.FatherName+"|"+student.PhoneNumber+"|"+student.DOB.ToString("dd/MM/yyyy")+"|"+student.TotalMark;
                sw.WriteLine(Line);
                }
                sw.Close();
        }
       

        static void ReadCSV()
        {
            List<StudentDetails> newList=new List<StudentDetails>();
            StreamReader sr=new StreamReader("TestFolder/data1.csv");
            string line=sr.ReadLine();
            while(line!=null)
            {
                string [] values= line.Split("|");
                if(values[0]!="")
                {
                        StudentDetails student = new StudentDetails()
                        {
                            Name=values[0],
                            FatherName=values[1],
                            PhoneNumber=values[2],
                            DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                            TotalMark=int.Parse(values[4])
                        };
                        newList.Add(student);
                }

                line=sr.ReadLine();
            }
            sr.Close();
            foreach(StudentDetails student in newList)
            {
                Console.WriteLine($"Student Name: {student.Name}\nFather Name: {student.FatherName}\nPhone Number: {student.PhoneNumber}\nDOB: {student.DOB}\nTotal Mark: {student.TotalMark}");
            }
        }
        
        static void WriteToJson(List<StudentDetails> studentList)
        {
            StreamWriter sw=new StreamWriter("TestFolder/myText.json");
            var option=new JsonSerializerOptions{
                WriteIndented=true
            };
            string jsonData=JsonSerializer.Serialize(studentList,option);
            sw.WriteLine(jsonData);
            sw.Close();
        }
            ReadJson();
            static void ReadJson()
            {
                StreamReader sr=new StreamReader("TestFolder/myText.json");
                List<StudentDetails> student=JsonSerializer.Deserialize<List<StudentDetails>>(File.ReadAllText("TestFolder/myText.json"));
                foreach(StudentDetails student1 in student)
                {
                    Console.WriteLine(student1.Name,student1.FatherName,student1.PhoneNumber,student1.DOB);
                }
            }
    }
}
