using System;

namespace OnlineLibrary;

class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("CSE","B.E");
        RackInfo rack=new RackInfo("A36",2,department.DepartmentName,department.Degree);
        BookInfo book=new BookInfo("A36",2,department.DepartmentName,department.Degree,"Romeo and Juliet","William Shakespeare",2000);
        book.DisplayInfo();
    }
}