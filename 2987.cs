using System;

class Program
{
    static void Main(string[] args) {
        string letras = "xABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char chars = char.Parse(Console.ReadLine());
        int indice = letras.IndexOf(chars);
        Console.WriteLine(indice);
    }
}