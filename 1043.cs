using System;

class Program
{
    static void Main(string[] args) 
    {
        string[] texto = Console.ReadLine().Split();
        double A = double.Parse(texto[0]);
        double B = double.Parse(texto[1]);
        double C = double.Parse(texto[2]);

        if (A < B + C && B < A + C && C < A + B)
            Console.WriteLine($"Perimetro = {A + B + C:N1}");
        else
            Console.WriteLine($"Area = {(A + B) * C / 2:N1}");
    }
}