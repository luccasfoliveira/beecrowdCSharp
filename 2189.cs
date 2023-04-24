using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                break;
            }
            count++;
            string[] txt = Console.ReadLine().Split();
            Console.WriteLine($"Teste {count}");
            short x = 0;
            while (x <= txt.Length)
            {
                if (x + 1 == short.Parse(txt[x]))
                {
                    Console.WriteLine(x + 1);
                    Console.WriteLine();
                    break;
                }
                x++;
            }
        }
    }
}