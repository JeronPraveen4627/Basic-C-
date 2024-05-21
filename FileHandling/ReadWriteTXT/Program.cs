using System;
using System.Collections;
using System.IO;
namespace ReadWriteTXT;
class PRogram
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("TestFolder");
            
        }
        else
        {
            Console.WriteLine("Already Exist");
        }
        if(!File.Exists("TestFolder/myText.txt"))
        {
            Console.WriteLine("Creating File...");
            File.Create("TestFolder/myText.txt").Close();
        }
        Console.WriteLine("Select option\n 1.Read From File\n2.Write From File");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr=new StreamReader("TestFolder/myText.txt");
                string read=sr.ReadLine();
                while(read!=null){
                Console.WriteLine(read);
                read=sr.ReadLine();
                }
                sr.Close();
                break;
            }
            case 2:
            {
                string[] contents=File.ReadAllLines("TestFolder/myText.txt");
                StreamWriter sw=new StreamWriter("TestFolder/myText.txt");
                Console.WriteLine("Enter what do you want to type");
                string newline=Console.ReadLine();
                string old="";
                foreach(string line in contents)
                {
                    old=old+line+"\n";
                }
                old=old+newline+"\n";
                sw.WriteLine(old);
                sw.Close();

                break;
            }
        }

    }
}
