using System;

class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int diferenca = (a*b)-(c*d);
        Console.WriteLine($"DIFERENÇA = {diferenca}");
    }
}