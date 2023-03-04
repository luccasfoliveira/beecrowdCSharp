using System;

class Program
{
    static void Main()
    {
       int x = Convert.ToInt32(Console.ReadLine());
       int y = Convert.ToInt32(Console.ReadLine());
       int maior = x, menor = y;
       if(y > x)
       {
        maior = y;
        menor = x;
       }
       for(int i = menor + 1; i < maior; i++)
       {
            if(i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
       }
    }
}