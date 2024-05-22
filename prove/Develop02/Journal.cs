using System.IO;

class Journal
{
    List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string generatedPrompt =newPrompt.GetRandomPrompt();
        Console.WriteLine(generatedPrompt);
        string response = Console.ReadLine();
        string time = DateTime.Now.ToString("h/mm/ss tt");
        Entry newEntry = new Entry();
        newEntry._entry = response;
        newEntry._entryDate = time;
        newEntry._entryPrompt = generatedPrompt;
        _entries.Add(newEntry);
    }

    public void Display()
    {
        Console.WriteLine($"{_entries}");
    }

    public void Save()
    {
        
    }

    public void Load()
    {
        Console.WriteLine("Load");
    }

    public void Quit()
    {
        Console.WriteLine("Thank you!");
    }
}