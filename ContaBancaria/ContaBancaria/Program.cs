using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco meuBanco = new Banco();

            ContaBancaria conta1 = new ContaBancaria("1010-5", "Ana Silva", 500.00m);
            meuBanco.AdicionarConta(conta1);

            Console.WriteLine($"Bem-vindo ao Banco, {conta1.Titular}!");

            conta1.Depositar(250.00m);
            bool saqueSucesso = conta1.Sacar(100.00m);

            if (saqueSucesso)
                Console.WriteLine("Saque realizado com sucesso!");
            else
                Console.WriteLine("Saldo insuficiente para o saque.");

           
            conta1.ExibirExtrato();

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}