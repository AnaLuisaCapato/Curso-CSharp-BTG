using System;
using System.Globalization;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Vamos calcular seu IR ----------" + (Environment.NewLine));
            Console.Write("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario <= 1200.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 2500.0)
            {
                imposto = salario * 0.10;
            }
            else if (salario <= 5000.0)
            {
                imposto = salario * 0.15;
            }
            else
            {
                imposto = salario * 0.20;
            }

            Console.WriteLine();

            if (imposto == 0)
            {
                Console.WriteLine(" --- ISENTO --- ");
            }
            else
            {
                Console.WriteLine("O valor a pagar é de R$: " + imposto.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}