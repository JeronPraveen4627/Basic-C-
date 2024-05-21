using System;
namespace Student;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Jeorn","Male",new DateTime(2001,02,05),"9685748596",80,80,80);
        student.CalculateTotal();
        student.CalculatePercentage();
        student.Display();
    }
}