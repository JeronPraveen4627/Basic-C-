using System;
using System.Security.Cryptography.X509Certificates;
namespace ShowingStudentDetails;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Praveen","Sivaraman",9685748596,"Praveen@gmail.com",DateTime.ParseExact("01/02/2001","dd/MM/yyyy",null),"Male");
        StudentDetails student=new StudentDetails(person.Name,person.FatherName,person.PhoneNumber,person.MailID,person.DOB,person.Gender,"SF1234","12","BIO-Maths","2018-2019");
        student.GetStudentInfo(); 
    }
}