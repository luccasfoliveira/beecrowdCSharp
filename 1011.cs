using System;

class Program
{
    static void Main()
    {
        const double pi = 3.14159;
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("VOLUME = " + (((4.0/3) * pi * Math.Pow(r, 3)).ToString("F3")));
    }
}