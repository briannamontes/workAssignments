
namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Messenger myMessenger = new Messenger();
            //Instantiate it, going to assign it to a variable, what type of variable is it, take class definition and create an object with "new"
            myMessenger.SayHello();

            Console.ReadLine();
        }
    }
}