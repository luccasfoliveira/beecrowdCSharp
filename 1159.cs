using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }

            if (num % 2 != 0)
            {
                num++;
            }
            int soma = num;
            for (int i = num + 2; i <= (num + 8); i += 2)
            {
                soma += i;
            }
            Console.WriteLine(soma);
        }
    }
}