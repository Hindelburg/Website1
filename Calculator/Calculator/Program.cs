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

        /// Main method for calculator.
        ///
        /// parameters: string[] args
        /// Returns: void
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

        /// Starts the calculator and keeps it running until q. 
        ///
        /// parameters: NA
        /// Returns: bool (True when you wish to continue to use the app.)
        bool DoCalculation()
        {
            Console.WriteLine("Please enter Q to quit\n");
            string input = "2 2 + ";
            Console.Write("> ");

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

        /// Tests to make sure the input is valid for calculator use.
        ///
        /// parameters: string input (Input is the calculation you wish to perform.)
        /// Returns: string (The answer to the inputted question.)
        string EvaluatePostFixInput(string input)
        {
            if(input == null || input == "")
            {
                throw new ArgumentException("Null or the empty string are not valid postfix expressions.");
            }
            stack.Clear();

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

        /// Does the actual calculations, catches errors when you divide by 0 or use an invalid operator.
        ///
        /// parameters: double a, double b, string s. (First value of expression, second value of expression, the operator.)
        /// Returns: double (The answer to the problem given in double format.)
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
