using System;

class Program
{
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            string num = Console.ReadLine();
            int count = 0;
            for(int j = 0; j < num.Length; j++) {
                if (num[j] == '0')
                    count += 1 + j;
                else if (6 % (int)num[j] != 0)
                    count++;
            }

            if (count == num.Length)
                Console.WriteLine("Cilada");
            else
                Console.WriteLine(count);
        }
    }
}