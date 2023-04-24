using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            byte N = Convert.ToByte(Console.ReadLine());
            if (N == 0)
            {
                break;
            }
            byte A = 0, B = 0;
            for (byte i = 0; i < N; i++)
            {
                string[] txt = Console.ReadLine().Split();
                if (byte.Parse(txt[0]) > byte.Parse(txt[1]))
                {
                    A++;
                }
                else if (byte.Parse(txt[0]) < byte.Parse(txt[1]))
                {
                    B++;
                }
            }
            Console.WriteLine($"{A} {B}");
        }
    }
}