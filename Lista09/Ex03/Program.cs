namespace Ex03
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

            Produto produto = new Produto(nomeProduto,precoProduto,quantidadeDisponivel);

            Console.WriteLine(produto.ExibirInformacoes());
        }
    }
}
