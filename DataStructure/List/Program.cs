using System;
namespace List;

class Program
{
    public static void Main(string[] args)
    {
        CustomList<int> numberList=new CustomList<int>(); 
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        CustomList<int> numbers=new CustomList<int>();
        numbers.Add(60);
        numbers.Add(70);
        numberList.AddRange(numbers);

        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }
        bool result=numberList.Contains(40);
        Console.WriteLine(result);

        int position=numberList.IndexOf(20);
        Console.WriteLine(position);

        numberList.InsertOf(3,90);
        Console.Write("Insert Element in a List ");
        for(int i=0;i<numberList.Count;i++)
        {
            Console.Write(numberList[i]+" ");
        }
        Console.WriteLine("");
        numberList.RemoveAt(4);
        Console.Write("Remove Index Element in a List  ");
        for(int i=0;i<numberList.Count;i++)
        {
            Console.Write(numberList[i]+" ");
        }
        numberList.Remove(20);
        Console.Write("\nRemove Element: ");
        for(int i=0;i<numberList.Count;i++)
        {
            Console.Write(numberList[i]+" ");
        }
    }
}