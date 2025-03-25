namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            decimal precoProduto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade disponível:");
            int quantidadeDisponivel = Convert.ToInt32(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, precoProduto, quantidadeDisponivel);

            Console.WriteLine(produto.ExibirInformacoes());

            bool menu = true;

            while (menu)
            {
                Console.WriteLine(@"Você deseja
                                    1 - Aumentar o estoque
                                    2 - Diminuir o estoque
                                    0 - Sair");
                int operacao = Convert.ToInt32(Console.ReadLine());

                switch (operacao)
                {
                    case 0:
                        menu = false;
                        break;
                    case 1:
                        Console.WriteLine("Insira a quantidade que quer inserir:");
                        int quantidadeAAumentar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(produto.AumentaEstoque(quantidadeAAumentar));
                        break;
                    case 2:
                        Console.WriteLine("Insira a quantidade que quer reduzir:");
                        int quantidadeADiminuir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(produto.ReduzEstoque(quantidadeADiminuir));
                        break;
                }

            }

            Console.WriteLine("Insira o nome da sua loja");
            string nomeLoja = Console.ReadLine();

            Loja loja = new Loja(nomeLoja);

            Console.WriteLine(loja.AdicionaProduto(produto));

            Console.WriteLine(loja.AdicionaProduto(new Produto("Camiseta", 50m, 10)));

            loja.ListarProdutos();
            
        }
    }
}

