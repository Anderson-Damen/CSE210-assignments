class Word
{
    public List<Word> _words = new List<Word>();
    public string _word;
    public string _hiddenWord;
    public void HideWord(string _word)
    {
        _hiddenWord = new string('_', _word.Length);
    }

    public void DisplayHiddenWord()
    {
        Console.WriteLine(_hiddenWord);
    }
}