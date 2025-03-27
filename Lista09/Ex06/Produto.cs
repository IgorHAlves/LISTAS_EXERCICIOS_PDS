using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public Produto(string nome, decimal Preco, int quantidadeDisponivel)
        {
            this.Nome = nome;
            this.Preco = Preco;
            this.QuantidadeDisponivel = quantidadeDisponivel;
        }
    }
}
