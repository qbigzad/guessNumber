using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class GetNumber
    {
        int wholeNums = new Random().Next(20);
        bool keepPlaying = true;
        int guessNum = 0;
        int guessCount = 0;

        public void Play()
        {
            Console.WriteLine("Let's Play! 'Guess the Number'!");
            Console.WriteLine("I am thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to quit the game.");


            do
            {
                Console.WriteLine("What's your guess?");
                string theInput = Console.ReadLine();
                bool result = Int32.TryParse(theInput, out guessNum);
                if (!result)
                {
                    Console.WriteLine("Hmmm, that does not look like a number, Try again.");
                }
                else
                {
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"Oh well. I was thinking of {wholeNums}");
                        keepPlaying = false;
                    }
                    else
                    {
                        guessCount++;
                        if(guessNum == wholeNums)
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepPlaying = false;
                        }
                        else
                        {
                            Console.WriteLine("Nope, {0} than that.", guessNum < wholeNums ? "higher" : "lower");
                        }

                    }
                }

            } while (keepPlaying);
        }
    }
}
