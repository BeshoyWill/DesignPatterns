using System.Linq.Expressions;
using static System.Console;

namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXXVIII";
            Context context = new Context(roman);

            // Build the 'parse Tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            //Interpret
            foreach(Expression exp in tree)
            {
                exp.Interpret(context);
            }

            WriteLine("{0} = {1}", roman, context.Output);

            Console.ReadKey();
        }
    }
}
