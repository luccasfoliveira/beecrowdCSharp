using System;

class Program
{
    static void Main(string[] args) {
        string[] texto = Console.ReadLine().Split();
        double N1 = double.Parse(texto[0]);
        double N2 = double.Parse(texto[1]);
        double N3 = double.Parse(texto[2]);
        double N4 = double.Parse(texto[3]);
        double exame, media_final;

        double media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10;

        if (media >= 7.0) {
            Console.WriteLine($"Media: {media:N1}");
            Console.WriteLine("Aluno aprovado.");
        }

        else if (media >= 5.0 && media <= 6.9) {
            exame = double.Parse(Console.ReadLine());
            Console.WriteLine($"Media: {media:N1}");
            Console.WriteLine("Aluno em exame.");
            Console.WriteLine($"Nota do exame: {exame:N1}");
            media_final = (media + exame) / 2;

            if (media_final >= 5)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");
            Console.WriteLine($"Media final: {media_final:N1}");
        }

        else {
            Console.WriteLine($"Media: {media:N1}");
            Console.WriteLine("Aluno reprovado.");
        }
    }
}