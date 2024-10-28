using System;

class Program
{
    //for added creatity, created a new activity and class called GuidedImageryActivity that provides a random image for the user to focus on for a set amount of time in seconds
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Guided Imagery Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Please make a selection 1-5: ");

            string input = Console.ReadLine();
            int duration;

  

            Activity activity = new Activity("", "", 0);

            if (input == "1")
            {
                duration = activity.GetActivityDuration();
                var breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through a simple breathing exercise.", duration);
                breathingActivity.Run();
            }
            else if (input == "2")
            {
                duration = activity.GetActivityDuration();
                var prompts = new List<string>
                {
                    "What are your greatest strenghts?",
                    "Name people, living or dead, who have influenced your life.",
                    "Who have you helped recently?",
                    "What are your favorite hobbies?",
                    "What are your favorite books?",
                    "What are your favorite movies?"
                };
                var listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration, prompts.Count, prompts);
                listingActivity.Run();
            }
            else if (input == "3")
            {
                duration = activity.GetActivityDuration();
                var prompts = new List<string>
                {
                    "Think of a time when you accomplished a difficult task.",
                    "Think of a time when you gave or received a random act of kindness.",
                    "Think of a talk or speech that gave you strenght.",
                    "Think of a spiritual experienced that helped you in a time of need."
                };
                var questions = new List<string>
                {
                    "Why does this memory stand out?",
                    "If you could change one thing about this event, what would it be?",
                    "What is a lesson you can take from this moment to share with others?",
                    "How can you use this experience to help or teach others?",
                    "How did you feel after completing this task?",
                    "Is this an experience you would like to repeat?",
                    "What was the best thing about this experience?",
                    "Who is the one person you would like to share this experience with?"
                };
                var reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times when you have shown strength and resilience.", duration, prompts, questions);
            }
            else if (input == "4")
            {
                duration = activity.GetActivityDuration();
                var image = new List<string>
                {
                    "Imagine a quiet beach with gently rolling waves.",
                    "Imagine a peaceful meadow surrounded by trees.",
                    "Imagine being suspended, floating gently with the current",
                    "Imagine sitting in front of a fireplace, watching the flames dance."
                };
                var guidedImageryActivity = new GuidedImageryActivity("Guided Imagery Activity", "This activity is designed to help you relax by imaging you are in a peaceful location.", duration, image);
            }
            else if (input == "5")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid Option.  Pleas choose from 1-4");
            }

            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }
}