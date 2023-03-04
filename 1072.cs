using System;

class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int fora = 0, dentro = 0;
        for(int i = 0; i < num; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n >= 10 && n <= 20)
                dentro += 1;
            else 
                fora += 1;
        }
        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");
    }
}