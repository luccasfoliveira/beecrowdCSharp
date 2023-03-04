using System;

class Program
{
    static void Main(string[] args)
    {
        string texto;
        while((texto = Console.ReadLine()) != null)
        {
            string[] subTexto = texto.Split(' ');
            long v1 = Fatorial(Convert.ToInt64(subTexto[0]));
            long v2 = Fatorial(Convert.ToInt64(subTexto[1]));

            Console.WriteLine(v1 + v2);
        }
    }
    static long Fatorial(long valor)
    {
        if(valor <= 1)
            return 1;
        return valor * Fatorial(valor - 1);
    }
}
