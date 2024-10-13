//for extra creativity, I added a ScriptureLibrary class that pulls a random scripture into the program

using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        string randomScripture = library.GetRandomScripture();
        Console.Clear();
        Console.WriteLine(randomScripture);

        Scripture scripture = new Scripture(randomScripture);
        Console.WriteLine("Press Enter to hide words.  Type quit when finished");

        while(true)
        {
            var input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words.  Type quit when finished");


            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}