namespace Fase05 {
    public class ConversorRelatorio : IConversor {
        public string Converter(decimal valor) {
            if (valor >= 1000000)
                return $"{(valor / 1000000):N2} Milhões de Reais";
            return $"R$ {valor:N2}";
        }
    }
}