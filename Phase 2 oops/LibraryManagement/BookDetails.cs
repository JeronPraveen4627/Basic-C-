using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
   
    public class BookDetails
    {
        //private field
        private static int s_bookID=1000;
        /*Properties:
        BookID (Auto Increment - BID1000)
        BookName
        AuthorName
        BookCount*/
        public string BookID{get;}
        public string BookName{get; set;}

        public string AuthorName{get; set;}

        public int BookCount{get; set;}

        public BookDetails(string bookName,string authorName,int bookCount)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            BookCount=bookCount;
        }

    }
}