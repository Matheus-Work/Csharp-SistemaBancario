using System;

namespace ConsoleApp10
{
    class Program
    {
        /*Criar um Sistema Bancário com os métodos verSaldo, deposito e saque.
          Desafio: criar um limite de -R$1000,00 reais, e limitar o depósito
          máximo de R$5000,00 reais.
        */
        static void verSaldo(double saldo)
        {
            Console.WriteLine("Seu saldo é de R${0:F2}", saldo);
        }
        static void saque(ref double saldo)
        {
            Console.WriteLine("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
            if ((saldo - saque)< 1000)
            {
                Console.WriteLine("Operação inválida\nSaldo Insuficiente");
            }
            else
            {
                saldo = saldo - saque;
            }
        }
        static void deposito(ref double saldo)
        {
            Console.WriteLine("Digite o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine());
            if (deposito > 5000)
            {
                Console.WriteLine("Operação inválida\nDepósito máximo por vez é de R$5000,00 reais");
            }
            else
            {
                saldo = saldo + deposito;
            }
        }
        static void Main(string[] args)
        {
            double saldo = 500;
            int opc;
            do
            {
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 Saldo\n2 Depósito\n3 Saque\n4 Sair");
                opc = int.Parse(Console.ReadLine());
                while (opc < 1 || opc > 4)
                {
                    Console.WriteLine("Erro\nDigite uma opção válida");
                    opc = int.Parse(Console.ReadLine());
                }
                switch (opc)
                {
                    case 1: verSaldo(saldo); break;
                    case 2: deposito(ref saldo); break;
                    case 3: saque(ref saldo); break;
                    case 4: Console.WriteLine("Obrigado, volte sempre!"); break;
                }
            } while (opc != 4);
            
        }
    }
}