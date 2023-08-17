using System;
namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[100];

            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next();
            }

            int maiorValor = vetor.Max();
            int menorValor = vetor.Min();

            Console.WriteLine("O maior valor é o " + maiorValor 
                + " que está na posição:" 
                + Array.IndexOf(vetor, maiorValor));
            Console.WriteLine("O menor valor é o " + menorValor
                + " que está na posição:" 
                + Array.IndexOf(vetor, menorValor));

            Console.ReadKey();
        }
    }
}
