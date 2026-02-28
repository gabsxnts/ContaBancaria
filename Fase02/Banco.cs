namespace Fase02 {
    public class Banco {
        private string nome;
        public string CodigoBACEN { get; set; }

        public string Nome {
            get => nome?.ToUpper();
            set => nome = value;
        }
    }
}