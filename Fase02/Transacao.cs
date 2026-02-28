using System;

namespace Fase02
{
    public class Transacao
    {
        private decimal _valor;
        public DateTime Data { get; set; }
        public string Tipo { get; set; }

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                
                if (value > 0)
                    _valor = value;
                else
                    Console.WriteLine("ERRO: Valor de transação inválido (deve ser > 0).");
            }
        }
    }
}