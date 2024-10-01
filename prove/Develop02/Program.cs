//for extra creativity, I added a "Press any key..." prompt between choices
//I also an else statement to the menu so that if any option other than 1-5 were selected, it would warn you that was an invalid selection and ton choose again
//I alos changed the program so that it will save to or load from a .csv file

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
   
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        string userChoice;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
        
            if (userChoice == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write("> ");
                Console.WriteLine(prompt);
                string userEntry = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = userEntry
                };
                journal.AddEntry(newEntry);
            } 
            else if (userChoice == "2")
            {
                Console.WriteLine("All Entries: ");
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("Enter the name of the file you would like to load: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
                Console.WriteLine($"Your file: {file} has loaded successfully.");
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter the name of the save file: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
                Console.WriteLine($"Your file: {file} saved successfully");
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Have a great day!");
            }
            else{
                Console.WriteLine("Invalid selection.");
            }
            if (userChoice != "5")
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }while (userChoice != "5");
    }
}