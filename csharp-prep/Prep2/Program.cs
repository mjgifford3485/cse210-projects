using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade: ");
        string percentage = Console.ReadLine();
        int numberGrade = int.Parse(percentage);
        string letterGrade = "";
        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade < 90 && numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade < 80 && numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade < 70 && numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is: {letterGrade}.");

        if (numberGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again, I know you can do it!");
        }

    }
}