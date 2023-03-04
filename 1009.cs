using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double vendas = Convert.ToDouble(Console.ReadLine()) * 0.15;

        Console.WriteLine("TOTAL = R$ " + (salario + vendas).ToString("F2"));
    }
}