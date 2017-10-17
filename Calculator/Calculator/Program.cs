using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private IStackADT stack = new LinkedStack();
        static void Main(string[] args)
        {
            Calculator app = new Calculator();
            bool playAgain = true;
            Console.WriteLine("\nPostfix Calculator. Recognizes these operators: + - * /");
            while(playagain)
            {
                playAgain = app.DoCalculation();
            }
            Console.WriteLine("Bye.");
        }

        bool DoCalculation()
        {
            Console.WriteLine("Please enter Q to quit\n");
            string input = "2 2 + ";
            Console.WriteLine("> ");

            input = Console.ReadLine();

            if(input[0] == "q" || input[0] == "Q")
            {
                return false;
            }
            string output = "4";
            try
            {
                output = EvaluatePostFixInput(input);
            }
            catch(ArgumentException e)
            {
                output = e.Message();
            }
            Console.WriteLine("\n\t>>> " + input + " = " + output);
            return true;
        }

        string EvaluatePostFixInput(string input)
        {
            if(input == null || input == "")
            {
                throw new ArgumentException("Null or the empty string are not valid postfix expressions.");
            }
            stack.clear();

            string s;
            double a;
            double b;
            double c;
        }

    }
}
