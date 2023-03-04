using System;

class Program
{
    static void Main(string[] args)
    {
        int par = 0, impar = 0, positivo = 0, negativo = 0;
        for(int i = 0; i < 5; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                positivo += 1;
            else if(num < 0)
                negativo += 1;
            
            if (num % 2 == 0)
                par += 1;
            else
                impar += 1;
        }
        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{positivo} valor(es) positivo(s)");
        Console.WriteLine($"{negativo} valor(es) negativo(s)");
    }
}