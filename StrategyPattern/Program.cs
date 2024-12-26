using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Strategy
{
    class Program
    {
        /// <summary>
        /// The Strategy pattern is a method by which we can move repeated if/then logic to polymorphism.
        /// In this example, we want to cook some food using a variety of different methods.
        /// In a naive example, we'd need an IF statement for each cooking method.
        /// If we have a lot of cooking methods, we'll also have a lot of IF statements.
        /// But in this example, we can define a Strategy for each cook method and simply set which one we want at runtime.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CookingMethod cookMethod = new CookingMethod();

            WriteLine("What food would you like to cook?");
            var food = ReadLine();
            cookMethod.SetFood(food);

            WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(ReadKey().KeyChar.ToString());


            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    WriteLine("Invalid Selection!");
                    break;
            }
            ReadKey();
        }
    }
}
