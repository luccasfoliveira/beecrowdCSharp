using System;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int maior, menor, soma = 0;

        if (a > b)
        {
            maior = a; 
            menor = b;
        }
        else
        {
            maior = b;
            menor = a;
        }
        
        menor += 1;

        while(menor < maior)
        {
            if(menor % 2 != 0)
                soma += menor;
            menor += 1;
        }
        Console.WriteLine(soma);
    }
}