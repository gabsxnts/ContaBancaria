using System;

namespace Fase03
{
    public class Transacao
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public string Descricao { get; set; }

        public virtual bool Validar()
        {
            return Valor > 0;
        }
    }
}