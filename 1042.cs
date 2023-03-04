using System;

class Program
{
    static void Main(string[] args) 
    {

        string[] texto = Console.ReadLine().Split();
        int A = int.Parse(texto[0]);
        int B = int.Parse(texto[1]);
        int C = int.Parse(texto[2]);
        int AUX;

        if(A > B) {
            AUX = A;
            A = B;
            B = AUX;
        }
        if(A > C) {
            AUX = A;
            A = C;
            C = AUX;
        }
        if(B > C) {
            AUX = B;
            B = C;
            C = AUX;
        }

        Console.WriteLine(A);
        Console.WriteLine(B);
        Console.WriteLine(C);
        Console.WriteLine();
        Console.WriteLine(int.Parse(texto[0]));
        Console.WriteLine(int.Parse(texto[1]));
        Console.WriteLine(int.Parse(texto[2]));
    }
}