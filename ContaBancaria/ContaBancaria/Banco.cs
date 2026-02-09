using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBancario
{
    public class Banco
    {
        private List<ContaBancaria> _contas = new List<ContaBancaria>();

        public void AdicionarConta(ContaBancaria conta)
        {
            _contas.Add(conta);
        }

        public ContaBancaria BuscarConta(string numero)
        {
            return _contas.FirstOrDefault(c => c.Numero == numero);
        }
    }
}