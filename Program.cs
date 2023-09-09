using System;

namespace Loops_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {


            //Number guessing game
            int guess;
            int randomNumber;
            bool incorrect = true;
            int guessCounter = 0;
            
            //This creates a random number using the Next method of the class Random
            Random rand = new Random();
            randomNumber = rand.Next(1, 6);


            //This is an EXIT-CONTROLLED, CONDITION-BASED loop.
            do
            {
                Console.WriteLine("Enter your guessed number");
                guess = Convert.ToInt16(Console.ReadLine());//Reads then response and converts to an integer

                //Checks for a match to change the boolean to false to allow exit from loop
                if(guess==randomNumber)
                {
                    incorrect = false;
                }
                guessCounter++;//Records the number of guesses
            }
            while (incorrect);

            //Next two lines demonstrate concatenation
            Console.WriteLine("You have correctly guessed the random number: "+ guess);
            Console.WriteLine("It took you " + guessCounter + "  guesses");
            Console.ReadKey();


        }
    }
}
