using System;

namespace MyApp // Exercicio01.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros");
            int primeiro = int.Parse(Console.ReadLine());
            int segundo = int.Parse(Console.ReadLine());

            int soma = primeiro + segundo;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}