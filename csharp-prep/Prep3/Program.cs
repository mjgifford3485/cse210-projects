using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        

        while (guess != number)
        {
            Console.Write("Please enter your guess: ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess < number)
            {
             Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("Correct");
            }
        }
    }
}