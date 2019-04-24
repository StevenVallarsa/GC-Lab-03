using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello there. What's your name? ");
            string name = Console.ReadLine();

            bool isTrue = true;

            while (isTrue)
            {

                Console.Write("\nHello {0}. Enter a number between 1 and 100: ", name);
                int yourNumber = CheckNumber();
                Console.WriteLine();

                if (yourNumber % 2 != 0)
                {
                    Console.WriteLine($"{yourNumber} Odd");
                }
                else if (yourNumber < 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else
                {
                    Console.WriteLine("Even.");
                }

                // Ask user if they want to do this again
                // - Takes first letter of response: if not
                //   "y" or "n" will ask user to try again.
                while (true)
                {
                    Console.Write("\nContinue? (y/n) ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "")
                    {
                        answer = " ";
                    }

                    if (answer[0] == 'n')
                    {
                        isTrue = false;
                        break;
                    }
                    else if (answer[0] == 'y')
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Oops. That's not a valid input. Please try again.");
                    }
                    

                }
            }

            Console.WriteLine("\nBye!");


        }
        // Method to check validity of user input.
        static int CheckNumber()
        {
            while (true)
            {
                string answer = Console.ReadLine();

                try
                {
                    int numberAnswer = Convert.ToInt32(answer);
                    if (numberAnswer > 0 && numberAnswer < 101)
                    {
                        return numberAnswer;
                    }
                    Console.WriteLine("Oops. You needs to input a positive integer between 1 and 100.");
                    Console.Write("Please Try again: ");
                }
                catch (Exception)
                {
                    Console.Write("Oops. You need to input an integer. Please try again: ");
                }
            }
        }
    }
}
