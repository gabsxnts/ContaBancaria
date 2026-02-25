using System;

namespace Fase04 {
    class Program {
        static void Main() {

            Cliente pf = new PessoaFisica { Nome = "Tiago", CPF = "123.456" };
            pf.Identificar();

            Transacao pix = new TransacaoPix { Valor = 100, ChavePix = "tiago@pix.com" };
            Console.WriteLine($"Pix Válido? {pix.Validar()}");
        }
    }
}