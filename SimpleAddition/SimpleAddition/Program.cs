// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace SimpleAddidtion
{ /// <summary>
/// dont understand
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: "); //asking user  to enter a number (writes out in same line)

            string userInput = Console.ReadLine(); //string is set equal to console readline, retireve first number from user

            int number1 = int.Parse(userInput); //turning a string into a number

            Console.Write("Enter the second number? "); // asking for second input

            userInput = Console.ReadLine(); //reassign the value to the next thing they type into the console 

            int number2 = int.Parse(userInput); //turning a string into a number

            int sum = number1 + number2; //print the sum of the two numbers 

            Console.WriteLine("The sum is: " + sum); //print the sum of the two numbers, a string and adding an integer to it 

            Console.WriteLine(" The sum is: " + sum.ToString()); //turning a number to a string (tostring)

            Console.WriteLine("The sum is: " + (number1 + number2)); //evaulate what is in the parenthesis first, then take the result, convert it to a string and put it in console writeline

            Console.ReadLine();
            
        }
    }
}
