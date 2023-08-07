using System;
using System.Runtime.Intrinsics.X86;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.Write("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < numero; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }
            Console.WriteLine(cont_in + "in");
            Console.WriteLine(cont_out + "out");
        }
    }
}