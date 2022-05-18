// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int playerGuess;
string playerInput;
bool isNumberGuessed = false;
int theAnswer;

Random rng = new Random();
theAnswer = rng.Next(1, 21);

//do
//{
//    Console.WriteLine("Enter your guess: ");
//    playerInput = Console.ReadLine();

//    playerGuess = int.Parse(playerInput);

//    if (playerGuess == theAnswer)
//    {
//        Console.WriteLine("You got it!");
//        isNumberGuessed = true;
//    }
//    else
//    {
//        if (playerGuess > theAnswer)
//        {
//            Console.WriteLine("Too high!");
//        }
//        else
//        {
//            Console.WriteLine("Too Low!");
//        }
//    }

//} while (!isNumberGuessed);


for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}

Console.ReadLine();
