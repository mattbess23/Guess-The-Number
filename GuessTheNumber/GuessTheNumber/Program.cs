using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int maximiumattempts = 10;

            Random randomList = new Random();

            while (run)
            {
                int randomNumberGenerator = randomList.Next(1, 101);

                Console.WriteLine("Can you guess the correct number? The number is between 1 and 100!");

                int attempts = 0;
                bool answer = false;
                while (!answer && attempts < maximiumattempts)
                {
                    attempts++;
                    int numberGuesses;
                    bool attemptedNumbernumberGuesseses;

                    do
                    {
                        attemptedNumbernumberGuesseses = int.TryParse(Console.ReadLine(), out numberGuesses);
                        if (!attemptedNumbernumberGuesseses)
                        {
                            Console.WriteLine("Please enter a number");
                        }
                    }

                    while (!attemptedNumbernumberGuesseses);

                    if (numberGuesses > randomNumberGenerator)
                    {
                        Console.WriteLine(string.Format("The number is lower than {0}\n please try again >>", numberGuesses));
                    }

                    else if (numberGuesses < randomNumberGenerator)
                    {
                        Console.WriteLine(string.Format("The number is higher than {0}\n please try again >>", numberGuesses));
                    }

                    else if (numberGuesses == randomNumberGenerator)
                    {
                        answer = true;
                        Console.WriteLine(string.Format("You guessed the correct number {0} and you needed {1} attempts", randomNumberGenerator, attempts));
                    }
                }

                if (!answer)
                {
                    Console.Clear();
                    Console.WriteLine(string.Format("You only have {0} attempts, Sorry you have failed!!! \n", maximiumattempts));
                }

                Console.WriteLine("Do you wish to play again? Press Y + Enter to play again!");

                string retry = Console.ReadLine().ToUpper();

                if (!retry.Equals("Y"))
                {
                    run = false;
                }
            }
            Console.Clear();
            Console.WriteLine("Thank you for playing, see you next time!");
            Console.ReadLine();
        }
    }
}
