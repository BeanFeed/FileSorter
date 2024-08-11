using System;
using Terminal.Gui;

namespace FileSorter;

class Program
{
    
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Please provide argument on how to run this application. <--service | --configure>");
            return;
        }

        if (args[0] == "-c" || args[0] == "--configure")
        {
            Console.Clear();
            Configure();
        }
        else if (args[0] == "-s" || args[0] == "--service")
        {
            Service();
        }
        else
        {
            Console.WriteLine("Invalid argument.\nPlease provide a valid argument on how to run this application. <--service | --configure>");
        }
    }

    static void Configure()
    {
        
    }

    static void Service()
    {
        
    }

    static string GetStringInput(string prompt = "", params string[] validOptions)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        while (input is null && (validOptions.Length > 0 && !validOptions.Contains(input!.ToLower())))
        {
            Console.WriteLine("Please provide valid input");
            Console.Write(prompt);
            input = Console.ReadLine();
        }

        return input!;
    }
}