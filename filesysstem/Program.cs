using System;
using System.IO;

namespace filesysstem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\source\repos\titpe21\sample";

            Console.WriteLine("Enter directory name");
            string userfolder = Console.ReadLine();

            string newDirectoryFullpath = @$"{rootDirectory}\{userfolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullpath);
            
            if (directoryExists)
            {
                Console.WriteLine($"{userfolder} disrectory already exists.");
                Console.WriteLine("would you like to crate a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine());

                if(userInput == "y")
                {
                    Console.WriteLine("enter file name:");
                    string userfile = Console.ReadLine() + ".txt";
                    string yserfukefullpath = $@"{newDirectoryFullpath}\{userfile}";
                    File.Create(userfilefullpath);    
                }

            }else
            {
                Directory.CreateDirectory(newDirectoryFullpath);
                Console.WriteLine($"directory {userfolder} has been created.");
            }
            
        }
    }
}
