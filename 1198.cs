using System;

class Program
{
    static void Main(string[] args) {

        string texto;
        while((texto = Console.ReadLine()) != null) {
            string[] subTexto = texto.Split();
            long x = long.Parse(subTexto[0]);
            long y = long.Parse(subTexto[1]);

            Console.WriteLine(Math.Abs(x - y));

        }
    }
}