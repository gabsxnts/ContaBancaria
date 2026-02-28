namespace Fase03
{
    public class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }
        public string TipoChave { get; set; }

        public override bool Validar()
        {
            return base.Validar() && Valor <= 10000;
        }
    }
}