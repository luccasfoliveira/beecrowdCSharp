using System;

class Program
{
    static void Main(string[] args)
    {
        string[] txt = Console.ReadLine().Split();
        Console.WriteLine($"{double.Parse(txt[0])/double.Parse(txt[1]):N2}");
    }
}