using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator calc = new SimpleCalculator();

            //nsole.WriteLine(calc.Square(4));

            Console.WriteLine(calc.AddTwoNumber(5, 6));
            Console.WriteLine("Enter a number to be aquared: ");

            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);
            Console.WriteLine(calc.Square(number));

            Console.WriteLine(calc.FindMaxOfThree(10, 5, 20));
            Console.ReadLine();

        }
    }
}