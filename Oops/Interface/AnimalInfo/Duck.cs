using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public class Duck:IAnimal
    {
        public string Name{get;set;}
        public string Habit{get;set;}
        public string EatingHabit {get;set;}

        public Duck(string name, string habit, string eatinghabit)
        {
            Name = name;
            Habit = habit;
            EatingHabit = eatinghabit; 
        }
         public void DisplayInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Habit}");
            Console.WriteLine($"{EatingHabit}");
        }
    }
}