using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Compras
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public decimal ValorTotal
        {
            get
            {
                return this.Produtos.Select(x => x.QuantidadeDisponivel * x.Preco).Sum();
            }
        }

        public string ValorTotalFormatado
        {
            get
            {
                return this.ValorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }


        public string AdicionaProdutoALista(Produto produto)
        {
            Produtos.Add(produto);
            return $"Produto adicionado com sucesso\nValor Total do produto: {produto.QuantidadeDisponivel * produto.Preco}\nValor Total da Lista: {this.ValorTotal}";
        }

        public void DescontoPix()
        {
            foreach (Produto produto in Produtos)
            {
                produto.Preco *= 0.95m;
            }
        }

        public void AumentoValorTotal(int parcelas)
        {
            if (parcelas <= 5)
            {
                foreach (Produto produto in Produtos)
                {
                    produto.Preco *= 1.05m;
                }
            }
            else
            {
                foreach (Produto produto in Produtos)
                {
                    produto.Preco *= 1.1m;
                }
            }
        }


    }
}
