namespace Fase03
{
    public class TransacaoTed : Transacao
    {
        public string BancoDestino { get; set; }
        public string CpfDestinatario { get; set; }

        public override bool Validar()
        {
            return base.Validar() && !string.IsNullOrEmpty(BancoDestino);
        }
    }
}