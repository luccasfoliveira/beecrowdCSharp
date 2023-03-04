using System;

class Program
{
    static void Main()
    {
        double nota;
        double soma = 0;
        int x = 0;
        while(true)
        {
            nota = Convert.ToDouble(Console.ReadLine());
            if(nota >= 0 && nota <= 10)
            {
                soma += nota;
                x += 1;
            }

            else
                Console.WriteLine("nota invalida");

            if(x == 2)
                break;
        }

        Console.WriteLine("media = " + ((soma)/2).ToString("F2"));
    }
}