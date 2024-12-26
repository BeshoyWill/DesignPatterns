using static System.Console;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bell = TheBell.Instance;
            bell.Ring();

            ReadKey();
        }
    }
}
