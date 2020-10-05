using System;

namespace Aula2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int[] numbers = new int[] {0, 5, 10, 15, 25};
            
            Console.WriteLine($"numero indice 1 = {numbers[1]}");
            numbers[1] = 99;
            Console.WriteLine($"Novo numero indice 1 = {numbers[1]}");

            int tam = numbers.Length;
            Console.WriteLine($"O vetor tem tamanho de: {tam}");
            Console.WriteLine($"O tamanho do vetor names e: {names.Length}");
            Console.WriteLine($"O tipo do vetor number e: {numbers.GetType().ToString()}");
            Console.WriteLine($"O tipo do vetor names e: {names.GetType().ToString()}");
        }
    }
}
