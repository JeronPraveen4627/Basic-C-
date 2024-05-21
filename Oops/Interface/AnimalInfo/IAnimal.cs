using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public interface IAnimal
    {
//        
        public string Name{get;set;}
        public string Habit{get;set;}

        public string EatingHabit {get;set;}

        public void DisplayInfo();

    }


}