public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was my favorite part about today?",
        "What is the most interesting thing I saw today?",
        "What was the most unexpected thing about my day?",
        "Who most brightened my day today and how?",
        "What is an opportunity I missed today and how could I avoid missing such opportunities in the future?",
        "What is my greatest accomplishment of today?"
    };

    public string GetRandomPrompt( )
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
}