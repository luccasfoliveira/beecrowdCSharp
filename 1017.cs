using System;

class Program
{
    static void Main(string[] args)
    {
        double tempo = double.Parse(Console.ReadLine());
        double distancia = double.Parse(Console.ReadLine());

        double vel = tempo * distancia / 12;
        Console.WriteLine($"{vel:N3}");
    }
}
