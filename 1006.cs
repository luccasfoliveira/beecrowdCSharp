using System;

class Program
{
    static void Main(string[] args)
    {
        double n1 = Convert.ToDouble(Console.ReadLine()) * 2;
        double n2 = Convert.ToDouble(Console.ReadLine()) * 3;
        double n3 = Convert.ToDouble(Console.ReadLine()) * 5;

        double media = (n1 + n2 + n3) / 10;
        Console.WriteLine($"MEDIA = {media:N1}");
    }
}