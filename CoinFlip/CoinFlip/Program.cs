// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int coin;
string userGuess;
string coinDescription = "Tails";
Random rng = new Random();
//Instantiation is when we load an object into memory for use (random number generator)

// Query the user
Console.Write("Enter your guess Heads or Tails (H or T)");
userGuess = Console.ReadLine();
//storing guess


//Get a random number for the coin flip
//2 is not included (from 0 between 2 but under 2)

coin = rng.Next(0, 2);
if (coin == 1)  
{
    coinDescription = "Heads";
}



if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
{
    Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
}
else
{ 
    Console.WriteLine("The coin flip was {0}, you lose!", coinDescription);
}

Console.ReadLine();
//doesn't quit the game