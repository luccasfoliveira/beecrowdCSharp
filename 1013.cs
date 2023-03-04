using System;

class Program
{
    static void Main()
    {
        int A, B, C, N1, N2;
        string[] v = Console.ReadLine().Split(' ');

        A = int.Parse(v[0]);
        B = int.Parse(v[1]);
        C = int.Parse(v[2]);

        N1 = (A + B + Math.Abs(A - B)) / 2;
        N2 = (N1 + C + Math.Abs(N1 - C)) / 2;

        Console.WriteLine(N2 + " eh o maior");
    }
}