using System;

namespace TaskTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"args {args.Length}");

            if (args.Length == 0)
            {
                ErrorMessages.ShowError();
            } 
            else if (args.Length == 1)
            {
                Controller.Action(args[0]);
            } 
            else if (args.Length == 2)
            {
                Controller.Action(args[0], args[1]);
            } 
            else
            {
                ErrorMessages.ShowError("Too many arguments.");
            }

        }

        
    }
}
