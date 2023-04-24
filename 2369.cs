using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int soma = 7;

        while (true)
        {
            if (n <= 10)
            {
                break;
            }

            if (11 <= n && n <= 30)
            {
                soma += (n - 10);
                break;
            }
            else if (31 <= n && n <= 100)
            {
                soma += (n - 30) * 2;
                n = 30;
            }
            else if (n > 100)
            {
                soma += (n - 100) * 5;
                n = 100;
            }
        }

        Console.WriteLine(soma);
    }
}
