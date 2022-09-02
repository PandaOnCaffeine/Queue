namespace Køen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables used to create guests and a bool to check if user wants to exit
            string name;
            byte age;
            bool exit = false;

            //A Variable with the ConsoleKeyInfo Datatype to check what key the user presses
            ConsoleKeyInfo choice;

            //Creates a objekt called menu with the class Menu
            Menu menu = new Menu();

            //Creates a Queue called queue
            Queue<Guests> queue = new Queue<Guests>();

            //A loop to keep the program running
            do
            {
                //Shows the menu using a public method from the menu objekt
                menu.ShowMenu(queue.Count);

                //Reads what key the user pressed
                choice = Console.ReadKey();

                //a switch the does different thing depending on what key the user pressed
                switch (choice.Key)
                {
                    //If key 1 is pressed
                    //Creates a guest and add the guest to the queue
                    case ConsoleKey.D1:
                        //Clears the console window
                        Console.Clear();

                        //Ask user for the guests name
                        Console.WriteLine("Enter guests name");
                        name = Console.ReadLine();

                        //Ask user for the guests age
                        Console.WriteLine("Enter guests age");
                        age = byte.Parse(Console.ReadLine());

                        //Creates a objekt guest with the name and age the user typed
                        Guests guest = new Guests(name, age);

                        //Adds user to the queue
                        queue.Enqueue(guest);

                        break;
                    //If key 2 is pressed
                    //Shows first guest in queue
                    case ConsoleKey.D2:

                        //Clears the console window
                        Console.Clear();
                        
                        //Shows the first guest in the queue
                        Console.WriteLine("First in line is " + queue.Peek());
                        
                        //tells the user, how to get back to the menu
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    //If key 3 is pressed
                    //Shows all guests in queue
                    case ConsoleKey.D3:
                        //Clears console window
                        Console.Clear();
                        
                        //writes some text
                        Console.WriteLine("People in queue:");
                        Console.WriteLine("");

                        //A loop that writes out each guests name and age
                        foreach (Guests g in queue)
                        {
                            Console.WriteLine(g);
                        }

                        //Creates a space
                        Console.WriteLine("");

                        //tells the user, how to get back to the menu
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    //If key 4 is pressed
                    //Exits the program
                    case ConsoleKey.D4:
                        //Sets the bool exit to true
                        exit = true;
                        break;
                    //Default
                    default:
                        break;
                }
                //Clears the Console window
                Console.Clear();

                //Loop runs while the bool exit isn't true
            } while (exit != true);
        }
    }
}