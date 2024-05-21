using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class RackInfo:DepartmentDetails
    {
        public string RackNumber{get; set;}

        public int ColumnNumber{get;set;}

        public RackInfo(string rackNumber,int columnNumber,string departmentName,string degree):base(departmentName,degree)

        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
    }
}