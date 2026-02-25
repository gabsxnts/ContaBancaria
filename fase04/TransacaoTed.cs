namespace Fase04 {
    public class TransacaoTed : Transacao {
        public string CodigoDestino { get; set; }
        public override bool Validar() => Valor > 0 && !string.IsNullOrEmpty(CodigoDestino);
    }
}