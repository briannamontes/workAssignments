// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args) //program starts
        {
            Console.Write("What is your name? "); //read and writes console, "write" keeps cursor on current line
            string name; //declaring a variable (storing a variable)

            name = Console.ReadLine(); //variable = the result of  console readline, returns a string

            Console.WriteLine("Hello " + name); //WriteLine print out message "+" concantenate strings

            Console.ReadLine(); //
        }
    }
} 