using System.IO;
using System.Net.Mail;
using System.Runtime.CompilerServices;

class Entry
{
    public string _entry;
    public string _entryDate = DateTime.Now.ToString("h/mm/ss tt");
    public string _entryPrompt = "";
    public StreamWriter outputfile;
    public void Display()
    {
        Console.WriteLine($"\n{_entryDate}: {_entryPrompt} {_entry}");
    }
    public void saveFile()
    {
        outputfile.WriteLine($"\nDate:{_entryDate}\nPrompt: {_entryPrompt}\nEntry: {_entry}\n");
    }

}