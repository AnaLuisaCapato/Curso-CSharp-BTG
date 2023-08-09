using Programa_estoque;
using System.Globalization;
using System;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("PRODUTO: ");
            produto.Nome = Console.ReadLine();
            Console.Write("PREÇO: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("QUANTIDADE EM ESTOQUE: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("DADOS DO PRODUTO:" + Environment.NewLine + "--> " + produto);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser --ADICIONADA--:");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS:" + Environment.NewLine + "--> " + produto);


            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser --REMOVIDA--:");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine("DADOS ATUALIZADOS:" + Environment.NewLine + "--> " + produto);
            Console.ReadKey();
        }
    }
}