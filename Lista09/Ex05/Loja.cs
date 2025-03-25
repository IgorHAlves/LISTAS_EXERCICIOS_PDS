using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Loja
    {
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Loja(string nome)
        {
            this.Nome = nome;
        }

        public string AdicionaProduto(Produto produto)
        {
            Produtos.Add(produto);
            return "Produto adicionado com sucesso";
        }

        public void ListarProdutos()
        {
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine($"Produto: {produto.Nome}\nPreco: {produto.Preco}\nQuantidade: {produto.QuantidadeDisponivel}");
                Console.WriteLine("------");
            }
        }
    }
}
