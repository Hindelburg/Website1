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
            while(playAgain)
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

            if(input[0] == 'q' || input[0] == 'Q')
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
                output = e.Message;
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

            double test;

            string[] divided = input.Split(new char[0]);

            for(int i = 0; i < divided.Length; i++)
            {
                if (Double.TryParse(divided[i], out test))
                {
                    stack.Push(Convert.ToDouble(divided[i]));
                }
                else
                {
                    s = divided[i];
                    if (stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting second operand.");
                    b = (Convert.ToDouble(stack.Pop()));
                    if (stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when expecting first operand.");
                    a = (Convert.ToDouble(stack.Pop()));
                    c = DoOperation(a, b, s);

                    stack.Push(Convert.ToDouble(c));
                }
            }
            return stack.Pop().ToString();
        }

        double DoOperation(double a, double b, string s)
        {
            double c = 0.0;
            if (s == "+")
                c = (a + b);
            else if (s == "-")
                c = (a - b);
            else if (s == "*")
                c = (a * b);
            else if (s == "/")
            {
                try
                {
                    c = (a / b);
                    if (c == double.NegativeInfinity || c == double.PositiveInfinity)
                        throw new ArgumentException("Can't divide by zero");
                }
                catch (ArithmeticException e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
            else
                throw new ArgumentException("Improper operator: " + s + ", is not one of +, -, *, or / ");
            return c;
        }
    }
}
