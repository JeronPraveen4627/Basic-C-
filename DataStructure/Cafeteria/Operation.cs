using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public  class Operation
    {

         public static CustomList<FoodDetails> foodList=new CustomList<FoodDetails>();

        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        public void AddDefaultValues()
        {
            FoodDetails food1=new FoodDetails("Coffee",20,100);
            FoodDetails food2=new FoodDetails("Tea",15,100);
            FoodDetails food3=new FoodDetails("Biscuit",10,100);
            FoodDetails food4=new FoodDetails("Juice",50,100);
            FoodDetails food5=new FoodDetails("Puff",40,100);
            FoodDetails food6=new FoodDetails("Milk",10,100);
            FoodDetails food7=new FoodDetails("Popcorn",20,20);

            CustomList

             



        }

        string userName=Console.ReadLine();
        string fatherName=Console.ReadLine();

        string mobile=Console.ReadLine();

        string mailID=Console.ReadLine();
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        int workStationNumber=int.Parse(Console.ReadLine());
        double _balance=double.Parse(Console.ReadLine());




    }
}