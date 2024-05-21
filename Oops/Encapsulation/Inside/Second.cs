using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inside
{
    public class Second:First
    {
        internal protected int InternalProtected=40;
        public int ProtectedNumberOut{get{return ProtectedNumber;}}
    }
}