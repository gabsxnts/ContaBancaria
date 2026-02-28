using System;

namespace Fase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            b.Nome = "banco centrado";
            b.CodigoBACEN = "002";

            Transacao t = new Transacao();
            t.Valor = -50.00m; 
            t.Data = DateTime.Now;

            Console.WriteLine("--- TESTE DE SEGURANÇA FASE 02 ---");
            Console.WriteLine("Banco: " + b.Nome);
            Console.WriteLine("Valor capturado: R$ " + t.Valor);
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}