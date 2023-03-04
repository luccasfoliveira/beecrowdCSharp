using System;

class Program
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < num; i++)
        {
            string[] texto = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(texto[0]);
            int n2 = Convert.ToInt32(texto[1]);
            
            int maior = n1, menor = n2;
            if(n2 > n1)
            {
                maior = n2;
                menor = n1;
            }
            Console.WriteLine(MDC(maior, menor));
        } 
    }
    static int MDC(int maior, int menor)
    {
        if(maior % menor == 0)
        {
            return menor;
        }
        return MDC(menor, (maior % menor));
    }
}