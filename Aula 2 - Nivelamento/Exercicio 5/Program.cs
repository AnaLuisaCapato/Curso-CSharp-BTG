using System;
namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.Write("Digite o numero do combustível desejado:");
            int produto = int.Parse(Console.ReadLine());

            while (produto != 4)
            {
                if (produto == 1)
                {
                    alcool = alcool + 1;
                }
                else if (produto == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (produto == 3)
                {
                    diesel = diesel + 1;
                }

                produto = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool:" + alcool);
            Console.WriteLine("Gasolina:" + gasolina);
            Console.WriteLine("Diesel:" + diesel);
        }
    }
}