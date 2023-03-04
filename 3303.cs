using System;

class Program
{
    static void Main(string[] args)
    {
        string texto = Console.ReadLine().ToString();
        if (texto.Length > 9)
            Console.WriteLine("palavrao");
        else
            Console.WriteLine("palavrinha");
    }
}