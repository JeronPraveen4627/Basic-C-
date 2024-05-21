using System;

        public class Program
        {
            public static void Main(string[] args)
            {
            char grade = char.Parse(Console.ReadLine());
            Switch(char)
            {
                case "E":
                
                    Console.WriteLine("Excellent");
                    break;
                
                case "V":
                
                    Console.WriteLine("Very Good");
                    break;
                
                case "G":
                
                    Console.WriteLine("Good");
                    break;
                
                case "A":
                
                    Console.WriteLine("Average");
                    break;
                
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default: 
                    Console.WriteLine("Invalid Grade");
            }
            }
        }