using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    static internal class ErrorMessages
    {
        internal static void ShowError(string message = "Invalid use.")
        {
            Console.WriteLine($"{message} Usage: task-tracker [command] [options]");
        }

    }
}
