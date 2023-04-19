using System;

class Program
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (Primo(num))
            {
                Console.WriteLine($"{num} eh primo");
            }
            else
            {
                Console.WriteLine($"{num} nao eh primo");
            }
        }
    }
    static bool Primo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i < Convert.ToInt32(Math.Sqrt(numero)) + 1; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}