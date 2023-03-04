using System;

class Program
{
    static void Main(string[] args)
    {
        string[] texto = Console.ReadLine().Split();
        double x1 = Convert.ToDouble(texto[0]);
        double y1 = Convert.ToDouble(texto[1]);

        texto = Console.ReadLine().Split();
        double x2 = Convert.ToDouble(texto[0]);
        double y2 = Convert.ToDouble(texto[1]);

        double distancia = Math.Sqrt((Math.Pow((x2-x1), 2)) + (Math.Pow((y2-y1), 2)));
        Console.WriteLine((distancia).ToString("F4"));
    }
}