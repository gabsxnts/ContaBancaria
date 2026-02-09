using System;

namespace SistemaBancario
{
    public class Transacao
    {
        public decimal Valor { get; }
        public string Descricao { get; }
        public DateTime Data { get; }

        public Transacao(decimal valor, string descricao, DateTime data)
        {
            Valor = valor;
            Descricao = descricao;
            Data = data;
        }
    }
}