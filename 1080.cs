using System;

class Program
{
    static void Main()
    {
        int maior = 0, indice = 0;
        for(int i = 1; i <= 100; i++)
        {
            int valor = Convert.ToInt32(Console.ReadLine());
            if(valor > maior)
            {
                maior = valor;
                indice = i;
            }
        }
        Console.WriteLine(maior);
        Console.WriteLine(indice);
    }
}