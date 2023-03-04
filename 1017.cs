using System;

class Program
{
    static void Main(string[] args)
    {
        int tempo = Convert.ToInt32(Console.ReadLine());
        int distancia = Convert.ToInt32(Console.ReadLine());

        double vel = tempo * distancia / 12;
        Console.WriteLine((vel).ToString("F3"));
    }
}