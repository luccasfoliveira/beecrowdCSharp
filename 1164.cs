using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int soma = 1;
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    soma += j;
                }
            }
            if (soma == num && soma != 1)
                {
                    Console.WriteLine($"{num} eh perfeito");
                }
            else
            {
                Console.WriteLine($"{num} nao eh perfeito");
            }
        }
    }
}