namespace Fase05 {
    public abstract class Transacao {
        public decimal Valor { get; set; }
        public abstract bool Validar();
    }
}