using static System.Console;

namespace CommandPattern
{
    internal class Program
    {
        /// <summary>
        /// The command pattern encapsulates commands as objects, allowing them to be executed by a 
        /// Receiver class and kicked off by an Invoker object. This enables more complex architectures such
        /// as CQRS (Command/Query Responsibility Segregation).
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            Patron patron = new Patron();
            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Remove the french fries
            patron.SetCommand(3 /*Add*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            ReadKey();
        }
    }
}
