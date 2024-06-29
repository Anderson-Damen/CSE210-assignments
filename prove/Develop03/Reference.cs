class Reference
{
    public string _book;
    public string _verse;
    public string _chapter;

    public void DisplayReference(string _book, string _verse, string _chapter)
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}