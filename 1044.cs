using System;

class Program
{
    static void Main()
    {
        string[] texto = Console.ReadLine().Split();
        int v1 = Convert.ToInt32(texto[0]);
        int v2 = Convert.ToInt32(texto[1]);

        int maior = v1;
        int menor = v2;

        if(v2 > v1)
        {
            maior = v2;
            menor = v1;
        }

        if(maior % menor == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");
    }
}