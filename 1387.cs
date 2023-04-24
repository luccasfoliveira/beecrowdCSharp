using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] txt = Console.ReadLine().Split();
            if (txt[0] == "0" && txt[1] == "0")
            {
                break;
            }
            int soma = byte.Parse(txt[0]) + byte.Parse(txt[1]);
            Console.WriteLine(soma);
        }
    }
}