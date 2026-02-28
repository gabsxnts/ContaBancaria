using System;

namespace Fase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA FINAL BANCO CENTRADO (INTERFACE) ---");

            var pixGov = new TransacaoPix { Valor = 5400000, ChavePix = "tesouro@nacional.gov" };

            IConversor relatorio = new ConversorRelatorio();
            string resultado = relatorio.Converter(pixGov.Valor);

            Console.WriteLine($"Tipo: PIX");
            Console.WriteLine($"Valor Real: {pixGov.Valor:C}");
            Console.WriteLine($"Relatório BACEN: {resultado}");
            
            Console.WriteLine("\n--- FIM DO PROJETO 02BC ---");
            Console.ReadKey();
        }
    }
}