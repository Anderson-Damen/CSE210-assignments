using System;
using System.Runtime.CompilerServices;
class Course
{
    public string _classCode;
    public string _classname;
    public int _credits;
    public string _color;

    public void Display() 
    {
        Console.WriteLine($"{_classCode}, {_classname}, {_credits}, {_color}");
    }
}

