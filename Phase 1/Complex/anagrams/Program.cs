using System;
namespace Anagrams;
class Program
{
    public static void Main(string[] args)
    {
           string str1 = Console.ReadLine();
           string str2 = Console.ReadLine();

            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            string res1 = new string(arr1);
            string res2 = new string(arr2);

            if (res1 == res2) 
            {
                Console.WriteLine("Anagram.");
            }
            else 
            {
                Console.WriteLine("Not anagram.");
            }
          
        }
    }
