using System;

class Program
{
    static void Main(string[] args)
    {
        double valorPositivo = 0, media;
        int count = 0;


        for(int i = 0; i < 6; i++)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            if(num > 0)
            {
                valorPositivo += num;
                count += 1;
            }
        }
        Console.WriteLine(count + " valores positivos");

        media = valorPositivo / count;
        Console.WriteLine(media.ToString("F1"));
    }
}
