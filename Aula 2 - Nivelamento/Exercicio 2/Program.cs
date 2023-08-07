using System;
using System.Globalization;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double horaTrab, salarioHora;
            double adicionaHoraExtra = 0.5;
            double horaExtra = 0;

            int horaMes = 40 * 4;

            try
            {
                Console.WriteLine("---------- Vamos calcular suas horas extras ----------" + (Environment.NewLine));
                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                horaTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o salário por hora: ");
                salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (horaTrab > horaMes)
                {
                    horaExtra = horaTrab - horaExtra;
                }

                double salarioDevido = horaExtra * salarioHora;

                Console.WriteLine("Seu Salário mensal é no valor de R$ " + horaMes * salarioHora);
                Console.WriteLine("Seu salário com a HORA EXTRA é R$ " + salarioDevido);

            }
            catch
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

        }
    }
}