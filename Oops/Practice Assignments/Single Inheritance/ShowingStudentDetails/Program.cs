using System;
namespace ShowingStudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        
        PersonalInfo person=new PersonalInfo("Jeron","Sivaraman",9685748596,"jeron@gmail.com",DateTime.ParseExact("05/02/2001","dd/MM/yyyy",null),Gender.Male);
        Console.WriteLine($"Name: {person.Name}\nFather Name: {person.FatherName}\nPhone Number: {person.PhoneNumber}\nMail ID: {person.MailID}\nGender: {person.Gender}");
        StudentInfo student=new StudentInfo("SF1234","Jeron","Sivaraman",9685748596,"jeron@gmail.com",DateTime.ParseExact("05/02/2001","dd/MM/yyyy",null),Gender.Male,12,"Computer Maths",2024);
        Console.WriteLine($"DOB: {student.DOB.ToShortDateString()}\nStandard: {student.Standard}\nBranch:{student.Branch}\nAcadamic Year:{student.AcadamicYear}");
    }
}