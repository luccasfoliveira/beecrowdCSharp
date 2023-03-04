using System;

class Program
{
    static void Main()
    {
        int soma = 0, maior = 0, menor = 0;
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        maior = a;
        menor = b;

        if(b > a)
        {
            maior = b;
            menor = a;
        }

        for(int i = menor; i <= maior; i++)
        {
            if(i % 13 != 0)
                soma += i;
        }
        Console.WriteLine(soma);
    }
}