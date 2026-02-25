using System;

namespace Fase04 {
    public abstract class Cliente {
        public string Nome { get; set; }
        public abstract void Identificar();
    }

    public class PessoaFisica : Cliente {
        public string CPF { get; set; }
        public override void Identificar() => Console.WriteLine($"PF: {Nome} | CPF: {CPF}");
    }

    public class PessoaJuridica : Cliente {
        public string CNPJ { get; set; }
        public override void Identificar() => Console.WriteLine($"PJ: {Nome} | CNPJ: {CNPJ}");
    }
}