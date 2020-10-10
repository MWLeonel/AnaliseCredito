using System;
using System.Xml;

namespace AnaliseCreditio
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcelas;
            decimal valor, valorParcela, valorMaximoParcela, rendaMensal;
            bool valorValido, parcelasValido, rendaMensalValido;

            Console.Write("Digite o Valor Desejado: ");
            valorValido = Decimal.TryParse(Console.ReadLine(), out valor);

            Console.Write("Digite a Quantidade de Parcelas Desejada: ");
            parcelasValido = int.TryParse(Console.ReadLine(), out parcelas);

            Console.Write("Digite a Sua Renda Mensal: ");
            rendaMensalValido = Decimal.TryParse(Console.ReadLine(), out rendaMensal);
            Console.WriteLine();

            if (valorValido && parcelasValido && rendaMensalValido)
            {
                valorParcela = valor / parcelas;
                valorMaximoParcela = rendaMensal * 0.3m;

                Console.WriteLine($"Sua Quantidade de Parcelas: {valorParcela:C}");
                Console.WriteLine($"Parcela Maxima: {valorMaximoParcela:C}");

                if (valorParcela <= valorMaximoParcela)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Parabens, seu credito foi aprovado e aproveite bem o seu dinheiro :)");
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sinto muito, seu credito não foi aprovado, tente numa proxima vez :(");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você digitou algum valor inválido. Tente novamente.");
            }

            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Pressione ENTER para sair!");
            Console.WriteLine("Obrigado Por Utilizar Meu Programa!");
            Console.ReadKey();
        }
    }
}
