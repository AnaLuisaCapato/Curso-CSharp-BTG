using System;
namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produto em estoque:");
            int qntdeAtual = int.Parse(Console.ReadLine());
            Console.Write("Digite a capacidade máxima de produto em estoque:");
            int qntdeMax = int.Parse(Console.ReadLine());
            Console.Write("Digite a capacidade mínima de produto em estoque:");
            int qntdeMin = int.Parse(Console.ReadLine());

            int qntdeMedia = (qntdeMax + qntdeMin) / 2;

            if (qntdeAtual >= qntdeMedia)
            {
                Console.WriteLine("Não efetuar compra!");
            }
            else
            {
                Console.WriteLine("Efetuar compra!!");
            }
            Console.ReadKey();
        }
    }
}
