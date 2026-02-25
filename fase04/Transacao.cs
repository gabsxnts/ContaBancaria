using System;

namespace Fase04
{
    public abstract class Transacao
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public abstract bool Validar();
    }
}