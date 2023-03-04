using System;

class Program
{
    static void Main()
    {
        int km = Convert.ToInt32(Console.ReadLine());
        double combustivel = km / Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((combustivel).ToString("F3") + " km/l");
    }
}