using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            byte n = byte.Parse(Console.ReadLine());
            if (n == 0)
            {
                break;
            }
            string[] txt = Console.ReadLine().Split();
            int soma = 10;
            int x = txt.Length - 1;
            while (x != 0)
            {
                if (short.Parse(txt[txt.Length - x - 1]) + 10 > short.Parse(txt[txt.Length - x]))
                {
                    soma += short.Parse(txt[txt.Length - x]) - short.Parse(txt[txt.Length - x - 1]);
                }
                else
                {
                    soma += 10;
                }
                x--;
            }
            Console.WriteLine(soma);
        }
    }
}