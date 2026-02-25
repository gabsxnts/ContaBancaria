namespace Fase04 {
    public class TransacaoPix : Transacao {
        public string ChavePix { get; set; }
        public override bool Validar() => Valor > 0 && !string.IsNullOrEmpty(ChavePix);
    }
}