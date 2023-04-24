using System;

class Program {
    static void Main(string[] args) {
        string[] input1 = Console.ReadLine().Split();
        int a = int.Parse(input1[0]);
        int b = int.Parse(input1[1]);
        int c = int.Parse(input1[2]);

        string[] input2 = Console.ReadLine().Split();
        int x = int.Parse(input2[0]);
        int y = int.Parse(input2[1]);
        int z = int.Parse(input2[2]);

        Console.WriteLine((x / a) * (y / b) * (z / c));
    }
}