namespace Ifood {
    public class Cliente {
        public string Nome { get; set; }

        public string EnderecoAtual { get; set; }

        public Cliente (string _nome) {
            this.Nome = _nome;
        }

        public string MostrarDados () {
            return $"Cliente: {Nome}, Endereço: {EnderecoAtual}";
        }

    }
}