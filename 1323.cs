using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            byte n = Convert.ToByte(Console.ReadLine());
            if(n == 0)
                break;
            int soma = 0;
            for (int i = 1; i <= n; i++)
                soma += (int)Math.Pow(i, 2);
            Console.WriteLine(soma);
        }
    }
}