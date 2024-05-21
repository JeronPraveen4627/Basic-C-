using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependence
{
    public class CCAccount:IAccount
    {
        public int AccountNumber{get;set;}

        public String Name{get;set;}

        public double Balance{get;set;}
    }
}