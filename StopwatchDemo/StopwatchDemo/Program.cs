namespace StopwatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press enter to start the timer.");
            Console.ReadLine();

            Stopwatch watch = new Stopwatch();

            watch.Start();

            Console.Write("Press enter to stop the timer.");
            Console.ReadLine();
            watch.Stop();


            Console.ReadLine();
        }
    }
}