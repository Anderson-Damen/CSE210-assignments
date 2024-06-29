using System;

class Program
{
    static void Main(string[] args)
    {
       Word word = new Word();
       word._word = "hello";
       word.HideWord(word._word);

       Console.WriteLine($"{word._hiddenWord}");
    }
}