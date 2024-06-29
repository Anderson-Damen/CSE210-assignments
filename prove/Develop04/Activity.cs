class Activity
{
    protected string _title;
    protected string _description;
    protected int _duration;
    
    //constructor
    public Activity(string title, string description, int duration)
    {
        _title = title;
        _description = description;
        _duration = duration;
    }
    
    public void animation()
    {
        while(true)
        {
            int delay = 500;
            Console.Write("|\b");
            Thread.Sleep(delay);
            Console.Write("\\\b");
            Thread.Sleep(delay);
            Console.Write("-\b");
            Thread.Sleep(delay);
            Console.Write("/\b");
            Thread.Sleep(delay);
        }
    }

    public void StartMessage()
    {
        Console.WriteLine("Welcome to the Activity. \n");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Get ready...");
    }
    public void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_title} Activity.");
        Console.WriteLine("Good Job!");
    }

}