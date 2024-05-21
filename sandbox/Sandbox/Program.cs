using System;

class Program
{
    static void Main(string[] args)
    {
        Course coursel = new Course();
        coursel._classCode = "CSE 210";
        coursel._classname = "programming with classes";
        coursel._credits = 2;
        coursel._color = "Green";

        coursel.Display();

    }
}