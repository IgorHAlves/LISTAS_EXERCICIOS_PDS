using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
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
    }
}
