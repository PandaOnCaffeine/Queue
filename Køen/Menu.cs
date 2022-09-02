using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    internal class Menu
    {
        //A method to show the menu
        public void ShowMenu(int guests)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("                           Queue");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"Guests in the queue {guests}");
            Console.WriteLine("");
            Console.WriteLine("1. Join queue");
            Console.WriteLine("2. First in queue");
            Console.WriteLine("3. Show all in queue");
            Console.WriteLine("4. Exit program");
            Console.WriteLine("");
            Console.WriteLine("Choose your number");
        }
    }
}
