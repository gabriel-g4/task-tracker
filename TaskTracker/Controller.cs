using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskTracker
{
    static internal class Controller
    {

        static internal void Action(string action)
        {
            if (action == "list")
            {

            } else
            {
                ErrorMessages.ShowError();
            }
        }

        static internal void Action(string action, string option)
        {
            if (action == "list")
            {

            }
            else
            {
                ErrorMessages.ShowError();
            }
        }

        static void List()
        {

        }

        static void List(string arg) {

        }
        
    }
}
