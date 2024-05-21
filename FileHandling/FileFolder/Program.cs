using System;
using System.IO;
using System.Security.Cryptography;
namespace FileFolder;

class Program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\PraveenSivaraman\OneDrive - Syncfusion\C# Training\FileHandling\MyFolder";
        string fileFolder=path+"/Jeron";
        if(!Directory.Exists(fileFolder))
        {
            Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory(fileFolder);
        }
        else 
        {
            Console.WriteLine("Folder is already Exist");
        }
        string filePath=path+"/myText.txt";
        if(!File.Exists(filePath))
        {
            Console.WriteLine("Creating a File...");
            File.Create(filePath);
        }
        else
        {
            Console.WriteLine("File is already exist");
        }
        Console.WriteLine("Select any one option\n1.Create Folder\n2.create File\n3.Delete Folder\n4.Delete File");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                Console.Write("Enter a Folder Name: ");
                string newFolder=Console.ReadLine();
                string newPath=path+"/"+newFolder;
                if(!Directory.Exists(newPath))
                {
                    Console.WriteLine("Creating a folder");
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                    Console.WriteLine("Already Exist");
                }
                break;
            }
            case 2:
            {
                Console.Write("Enter a file Name: ");
                string file=Console.ReadLine();
                Console.Write("Enter Extension: ");
                string extension=Console.ReadLine();
                string newFile=path+"/"+file+"."+extension;
                if(!File.Exists(newFile))
                {
                    Console.WriteLine("Creating a file...");
                    File.Create(newFile);
                }
                else
                {
                    Console.WriteLine("File already exist");
                }
                break;
            }
            case 3:
            {
                foreach(string path1 in Directory.GetDirectories(path))
                {
                        Console.WriteLine(path1);
                }
                Console.WriteLine("Enter a folder you wish to delete:");
                string removeFolder=Console.ReadLine();
                 foreach(string path1 in Directory.GetDirectories(path))
                {
                    if(path1.Contains(removeFolder))
                    {
                        Console.WriteLine("Removing Folder...");
                        Directory.Delete(path1);
                    }
                }
                
                break;
            }
            case 4:
            {
                foreach(string file in Directory.GetFiles(path))
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine("Enter a file name you wish to Delete:");
                string removeFile=Console.ReadLine();

                 foreach(string file in Directory.GetFiles(path))
                {
                    if(file.Contains(removeFile))
                {
                    Console.WriteLine("Deleting File...");
                    File.Delete(file);
                }
                }
                break;
            }

        }

    }   
}