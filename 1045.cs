using System;

class Program
{
    static void Main()
    {
        string[] texto = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(texto[0]);
        double B = Convert.ToDouble(texto[1]);
        double C = Convert.ToDouble(texto[2]);
        double aux;

        if(A < B)
        {
            aux = A;
            A = B;
            B = aux;       
        }
        if(A < C)
        {
            aux = A;
            A = C;
            C = aux; 
        }

        if(A >= (B + C))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if(Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if(Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if(Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            
            if(A == B && B == C)
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if(A == B || B == C || C == A)
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}