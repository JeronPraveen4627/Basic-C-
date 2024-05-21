using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        //No fields and Constructor
        //Property
        int Number{get; set;}//Declaration

        int Calculate();//Method - Declaration
        
        //Fully abstraction - no definition
    }
}