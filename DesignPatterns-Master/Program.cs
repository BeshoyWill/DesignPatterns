using static System.Console;

namespace DesignPatterns_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create handlers
            var additionHandler = new AdditionHandler();
            var subtractionHandler = new SubtractionHandler();
            var multiplicationHandler = new MultiplicationHandler();

            //create chain
            subtractionHandler.AddChain(multiplicationHandler);
            additionHandler.AddChain(subtractionHandler);

            //Execution
            double[] numbers = [2, 3, 4, 5];
            var additionResult = additionHandler.Handle(numbers, "Add");
            var subtractionResult = additionHandler.Handle(numbers, "Minus");
            var multResult = additionHandler.Handle(numbers, "Multiply");
            var divisionResult = additionHandler.Handle(numbers, "divide");

            WriteLine("Addition = {0}", additionResult);
            WriteLine("Subtraction = {0}", subtractionHandler);
            WriteLine("Multiplication = {0}", multResult);
            WriteLine("Division = {0}", divisionResult);
        }
    }
}
