using System;

class Program {
    static void Main(string[] args) {
        string[] n = Console.ReadLine().Split();
        int p = Convert.ToInt32(n[1]) - 1;
        string[] arr = new string[Convert.ToInt32(n[0])];

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = Console.ReadLine();
        }

        Array.Sort(arr);
        Console.WriteLine(arr[p]);
    }
}