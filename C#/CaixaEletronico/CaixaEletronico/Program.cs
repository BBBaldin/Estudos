using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            double valorSaldo = 0, valorOperacao = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("******* Caixa Eletrônico *******");
                Console.WriteLine("1 - Sacar");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Saldo");
                Console.WriteLine("0 - Sair");

                Console.Write("Informe uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n**** SACAR ****\n");
                        Console.WriteLine("Informe o valor a sacar: ");
                        valorOperacao = double.Parse(Console.ReadLine());
                        valorSaldo = valorSaldo - valorOperacao;
                        break;
                    case 2:
                        Console.WriteLine("\n**** DEPOSITAR ****\n");
                        Console.WriteLine("Informe o valor a depositar: ");
                        valorOperacao = double.Parse(Console.ReadLine());
                        valorSaldo = valorSaldo + valorOperacao;
                        break;
                    case 3:
                        Console.WriteLine("\n**** SALDO ****\n");
                        if (valorSaldo > 0) Console.ForegroundColor = ConsoleColor.Green;
                        else Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Saldo: R$ {valorSaldo.ToString("n")}");
                        break;
                    default:
                        Console.WriteLine("\n**** ERRO ****\n");
                        Console.WriteLine("Informe uma Opção Válida, Número de 0 a 3");
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo da conta...");
                        Console.WriteLine("\nPresione qualquer tecla para sair");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
            }
            while (opcao != 0);

            
        }
    }
}
