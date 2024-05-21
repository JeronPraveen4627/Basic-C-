using System;
using Microsoft.Win32.SafeHandles;

namespace MultiInheritance;

class Program
{
    public static void Main(string[] args)
    {
        
            PersonalDetails person=new PersonalDetails("Praveen","Sivaraman",Gender.Male,9655785685);

            Console.Write($"User ID : {person.UserID}\nUser Name : {person.UserName}\nFather Name: {person.FatherName}\nGender: {person.Gender}\nPhone Number: {person.PhoneNumber}");

            StudentDetails student= new StudentDetails(person.UserID,person.UserName,person.FatherName,person.Gender,person.PhoneNumber,1,2024);

            EmployeeDetails employee=new EmployeeDetails(person.UserID,person.UserName,person.FatherName,person.Gender,person.PhoneNumber,1,2024,"Chennai");

            Console.Write($"\nStandard: {student.Standard}\nYear of Joining: {student.YearOfJoining}");
    }
}