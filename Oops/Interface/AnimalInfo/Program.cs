using System;
namespace AnimalInfo;
class Program
{
    public static void Main(string[] args)
    {
        Duck duck1 = new Duck("duck1","habit1","eating1");
        duck1.DisplayInfo();
        Duck duck2 = new Duck("duck2","habit2","eating2");
        duck2.DisplayInfo();

        Dog dog1=new Dog("dog1","habit1","eating1");
        dog1.DisplayInfo();
    }
}