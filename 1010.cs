using System;

class Program
{
    static void Main()
    {
        string[] texto1 = Console.ReadLine().Split(' ');
        int qnt1 = Convert.ToInt32(texto1[1]);
        double vlr1 = Convert.ToDouble(texto1[2]);

        string[] texto2 = Console.ReadLine().Split(' ');
        int qnt2 = Convert.ToInt32(texto2[1]);
        double vlr2 = Convert.ToDouble(texto2[2]);

        double soma = (qnt1 * vlr1) + (qnt2 * vlr2);

        Console.WriteLine($"VALOR A PAGAR: R$ " + (soma).ToString("F2"));
    }
}