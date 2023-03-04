using System;

class Program
{
    static void Main(string[] args)
    {
        string[] texto = Console.ReadLine().Split();

        double A = Convert.ToDouble(texto[0]);
        double B = Convert.ToDouble(texto[1]);
        double C = Convert.ToDouble(texto[2]);

        Console.WriteLine($"TRIANGULO: {A*C/2:N3}");
        Console.WriteLine("CIRCULO: " + (C*C*3.14159).ToString("F3"));
        Console.WriteLine($"TRAPEZIO: {((A+B)*C)/2:N3}");
        Console.WriteLine($"QUADRADO: {B*B:N3}");
        Console.WriteLine($"RETANGULO: {A*B:N3}");
    }
}