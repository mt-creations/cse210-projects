

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What was one challenge you faced today?",
        "What did you learn today?",
        "In what ways did you feel blessed today?",
        "How did you show love to your family today?"
    };

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int i = prompt.Next(_prompts.Count);
        return _prompts[i];
    }


}