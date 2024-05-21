using System;
namespace CollegeAdmission;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal1=new PersonalInfo("Jeron","Sivaraman",9685748596,"Male","Jeron@gmail.com",new DateTime(2001,05,02));
        StudentInfo student1=new StudentInfo(personal1.Name,personal1.FatherName,personal1.PhoneNumber,personal1.Gender,personal1.MailID,personal1.DOB,"B.E","CSE",8);
        Teacher teacher1=new Teacher(personal1.Name,personal1.FatherName,personal1.PhoneNumber,personal1.Gender,personal1.DOB,personal1.MailID,"B.E","CSE","Maths",8,2020);
        PrincipalInfo principal=new PrincipalInfo(personal1.Name,personal1.FatherName,personal1.PhoneNumber,personal1.Gender,personal1.MailID,personal1.DOB,"Phd",7,2020);
        Console.WriteLine("Student Details");
        student1.ShowDetails();
        Console.WriteLine();
        Console.WriteLine("Teacher Details");
        teacher1.ShowDetails();
        Console.WriteLine();
        Console.WriteLine("Principal Details");
        principal.ShowDetails();


    }
}