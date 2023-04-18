using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] texto = Console.ReadLine().Split();
            int A = int.Parse(texto[0]);
            int B = int.Parse(texto[1]) * 2 - 1;

            if (A % 2 == 0)
            {
                A++;
            }

            int soma = A;
            for (int j = A + 2; j < (A + B); j += 2)
            {
                soma += j;
            }
            Console.WriteLine(soma);
        }
    }
}