using System;
using System.Collections.Generic;

namespace Fase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- SISTEMA DE FISCALIZAÇÃO FASE 03 ---");

            List<Transacao> listaFiscalizacao = new List<Transacao>();

            listaFiscalizacao.Add(new TransacaoPix { 
                Valor = 12000, 
                ChavePix = "tiago@email.com", 
                Descricao = "Compra de Notebook" 
            });

            listaFiscalizacao.Add(new TransacaoTed { 
                Valor = 7000, 
                BancoDestino = "001", 
                Descricao = "Transferência de Aluguel" 
            });

            foreach (var t in listaFiscalizacao)
            {
                string status = t.Validar() ? "APROVADA" : "REPROVADA (Análise AntiFraude)";
                Console.WriteLine($"Tipo: {t.GetType().Name} | Valor: {t.Valor:C} | Status: {status}");
            }

            Console.ReadKey();
        }
    }
}