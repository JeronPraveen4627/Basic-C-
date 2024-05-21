using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo:RackInfo
    {
        public string BookName{get;set;}

        public string AuthorName{get;set;}
        public int Price{get;set;}

        public BookInfo(string rackNumber,int columnNumber,string departmentName,string degree,string bookName,string authorName,int price):base( rackNumber, columnNumber, departmentName,degree)
        {
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}\nDegree: {Degree}\nRack Number: {RackNumber}\nColumn Number: {ColumnNumber}");
            Console.WriteLine($"Book Name: {BookName}\nAuthor Name: {AuthorName}\nPrice: {Price}");

        }    
    }

}