using System;

class Program
{
    static void Main()
    {
        int a = 0, g = 0, d = 0;
        while(true)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if(x >= 1 && x <= 4)
            {
                if(x == 3)
                   d += 1;
                else if(x == 1)
                    a += 1;
                else if(x == 2)
                    g += 1;
                else if(x == 4)
                    break;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + a);
        Console.WriteLine("Gasolina: " + g);
        Console.WriteLine("Diesel: " + d);
    }
}