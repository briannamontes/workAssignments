Console.WriteLine("Hello, World!");
string playAgain = string.Empty;
do
{
    //ask user choice
    Console.Write("What is your choice (R)ock, (P)aper, (S)cissors? ");
    //store choice in variable
    string userChoice = Console.ReadLine();
    userChoice = userChoice.ToLower();
    //computer choice, stored in variable, storing random # in computer choice
    Random rng = new Random();
    int randomNumber = rng.Next(1, 3);
    string computerChoice = string.Empty;
    //convert computer choice into a string
    //if Random number is 1 then atring variable = r
    if (randomNumber == 1)
    {
        computerChoice = "r";
    }

    //if Random number is 2 then atring variable = s
    if (randomNumber == 2)
    {
        computerChoice = "s";
    }
    //if Random number is 3 then atring variable = p
    if (randomNumber == 3)
    {
        computerChoice = "p";
    }
    Console.WriteLine("computer choice: " + computerChoice);
    //compare computer choice and user choice

    //if computer chooses rock and user picks rock, ties
    string result = string.Empty;
    if (computerChoice == userChoice)
    {
        result = "ties";
    }

    //if computer chooses rock and user picks paper, user wins
    if (computerChoice == "r" && userChoice == "p")
    {
        result = "user wins";
    }

    //if computer chooses rock and user picks scissors, computer wins
    if (computerChoice == "r" && userChoice == "s")
    {
        result = "computer wins";
    }

    //if computer chooses paper and user picks scissors, user wins
    if (computerChoice == "p" && userChoice == "s")
    {
        result = "user wins";
    }

    //if computer chooses paper and user picks rock, computer wins
    if (computerChoice == "p" && userChoice == "r")
    {
        result = "computer wins";
    }

    //if computer chooses scissors and user picks rock, user wins
    //if computer chooses scissors and user picks paper, computer wins
    if (computerChoice == "s")
    {
        if (userChoice == "r")
        {
            result = "user wins";
        }
        else if (userChoice == "p")
        {
            result = "computer wins";
        }
        else
        {
            result = "ties";
        }
    }


    //print user if win or lose
    Console.WriteLine(result);

    //ask to play again, store in variable
    Console.WriteLine("Do you want to continue (Y or N)? ");
    playAgain = Console.ReadLine();

}
while (playAgain == "y");


//if user plays again, repeat, if not close program