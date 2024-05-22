class PromptGenerator
{
    public List<string> _prompts = new List<string>(){
    "What was the best part of my day?",
    "Who was the most interesting person I interacted with today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "How did I see the hand of the Lord in my life today?",
    "What was the hardest thing to happen today?"
    };

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        return _prompts[index];
    }
}