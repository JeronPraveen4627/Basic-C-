using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public class Dog:IAnimal
    {
       // Method: Display info
       public string Name{get;set;}
        public string Habit{get;set;}

        public string EatingHabit {get;set;}

        public Dog(string name, string habit, string eatinghabit)
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