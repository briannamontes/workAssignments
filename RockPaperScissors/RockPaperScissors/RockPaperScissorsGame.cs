using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RockPaperScissorsGame
    {
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();

        }

        public void play()
        {
            string userChoice;
            userChoice = PromptUser;

        }

        private string PromptUser()
        {
            Console.Write("Enter your choice (R)ock, (P)aper, (S)cissors, or (Q)uit: ");
            string choice = Console.ReadLine();


            if (choice == "R", "P", "S", "Q")
        }
    }
}
