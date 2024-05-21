using System;

namespace HierarchircalInheritance;
class Program
{
    public static void Main(string[] args)
    {
        // Console.Write("Enter your Name: ");
        // string userName=Console.ReadLine();
        // Console.WriteLine("Enter your FatherName: ");
        // string fatherName=Console.ReadLine();
        // Console.Write("Enter your Phone Number: ");
        // long numberFather=long.Parse(Console.ReadLine());

            PersonalDetails person=new PersonalDetails("Praveen","Sivaraman",Gender.Male,9655785685);

            Console.WriteLine($"User ID : {person.UserID}\nUser Name : {person.UserName}\nFather Name: {person.FatherName}\nGender: {person.Gender}\nPhone Number: {person.PhoneNumber}");

            StudentDetails student= new StudentDetails(person.UserID,person.UserName,person.FatherName,person.Gender,person.PhoneNumber,1,2024);
            Console.WriteLine($"\nStandard: {student.Standard}\nYear of Joining: {student.YearOfJoining}");

            CustomerDetails customer=new CustomerDetails(person.UserID,person.UserName,person.FatherName,person.Gender,person.PhoneNumber,1000);

            Console.WriteLine($"User ID: {person.UserID}\nUser Name: {person.UserName}\nFather Name: {person.FatherName}\nGender: {person.Gender}\nPhone Number: {person.PhoneNumber}\nCustomer ID: {customer.CustomerID}\nBalance: {customer.Balance}");
    }       

}