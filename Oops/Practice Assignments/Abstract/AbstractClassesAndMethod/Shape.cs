using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethod
{
    public abstract class Shape //Abstract Class
    {
        //Abstract class-Partial abstraction.
        // It has fields, property, method, constructor, destructor, indexers, events
        // Can have both abstract declaration and normal definitions.
        //Can only used with an inherited class
        //Not support multiple inheritance
        //it cannot be static class
     
        protected string _name; //Normal Field 

        //Abstract Property
        public abstract string Area{get; set;}//Abstract Property

        public int volume{get;set;}

        public string Display() //Normal Method
        {
            return _name;
        }

        public abstract double Salary(int dates);//Abstract Method - Only Declaration
    }
}