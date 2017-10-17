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
        }
    }
}
