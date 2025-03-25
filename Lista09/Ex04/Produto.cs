using System.Globalization;

namespace Ex04
{
    internal class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public string PrecoFormatadoParaMoeda
        {
            get { return this.Preco.ToString("C", CultureInfo.GetCultureInfo("pt-br")); }
        }

        public Produto(string nome, decimal preco, int quantidadeDisponivel)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.QuantidadeDisponivel = quantidadeDisponivel;
        }

        public string ExibirInformacoes()
        {
            return $"{this.Nome} ({this.QuantidadeDisponivel}) {PrecoFormatadoParaMoeda}";
        }

        public string AumentaEstoque(int quantidade)
        {
            this.QuantidadeDisponivel += quantidade;
            return $"Estoque aumentado com sucesso.\nEstoque atual: {this.QuantidadeDisponivel}";
        }

        public string ReduzEstoque(int quantidade)
        {
            if (this.QuantidadeDisponivel >= quantidade)
            {
                this.QuantidadeDisponivel -= quantidade;
                return $"Quantidade reduzida com sucesso.\nEstoque restante: {this.QuantidadeDisponivel}";
            }
            else
            {
                return "Não foi possssivel reduiz o estoque, a quantidade solicitada é maior que o estoque atual.";
            }
        }
    }
}
