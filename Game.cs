using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpOrDown
{
    public class Game
    {
        //Initializing Variables
        int guesses { get; set; }
        Random makeRandomNumber = new();
        int numberToGuess { get; set; }

        Game()
        {
            guesses = 10;
        }

        public void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. Exit");
            MenuSelection();
        }

        void MenuSelection()
        {
            Console.WriteLine("Choosing:");
            int selection = Convert.ToInt32(Console.ReadLine());

            numberToGuess = makeRandomNumber.Next(100 + 1);

            guesses = 10;

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    StartGame();
                    break;
                default:
                    break;
            }
        }

        void StartGame()
        {
            Console.WriteLine("Guesses Left: " + guesses);

            while (guesses > 0)
            {
                GameLoop();
            }

            Menu();
        }

        void GameLoop()
        {
            Console.WriteLine("Guess a number between 0 and 100");
            Console.Write("Guess: ");

            int guessNumber = Guessing();

            if (guessNumber != numberToGuess)
            {
                guesses--;
                Console.WriteLine("Guesses left: " + guesses);
            }
            else if (guessNumber == numberToGuess)
            {
                Console.WriteLine("Number was correct won the game!");
                guesses = 0;
            }
        }


        int Guessing()
        {
            int guess = 0;
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > numberToGuess)
            {
                Console.WriteLine("The Number is lower than your number.");
            }
            else if (guess < numberToGuess)
            {
                Console.WriteLine("The number is greater than your number.");
            }
            return guess;
        }
    }
}
