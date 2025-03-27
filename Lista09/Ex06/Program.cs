using System.Globalization;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Compras compras = new Compras();

                while (true)
                {
                    Console.WriteLine("Escreva o nome do produto: ");
                    string nomeProduto = Console.ReadLine();
                    if (nomeProduto == "")
                    {
                        Console.WriteLine("Lista de compras finalizada!");
                        break;
                    }
                    Console.WriteLine("Escreva o preço untário");
                    decimal precoProduto = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escreva a quantidade");
                    int quantidadeEstoque = Convert.ToInt32(Console.ReadLine());

                    Produto produto = new Produto(nome: nomeProduto, Preco: precoProduto, quantidadeDisponivel: quantidadeEstoque);

                    Console.WriteLine(compras.AdicionaProdutoALista(produto));
                }

                Console.WriteLine("Escolha sua forma de pagamento:\n1 - PIX ou Dinheiro\n2 - Cartão de Débito\n3 - Cartão de Crédito");
                while (true)
                {
                    int formaPagamento = Convert.ToInt32(Console.ReadLine());
                    switch (formaPagamento)
                    {
                        case 1:
                            {
                                compras.DescontoPix();
                                Console.WriteLine("Metodo de pagamento escolhido: Pix ou Dinheiro, você ganhou 5% de desconto!");
                                Console.WriteLine($"Valor total da compra: {compras.ValorTotalFormatado}");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Método de pagamento escolhido: Débito");
                                Console.WriteLine($"Valor total da compra: {compras.ValorTotalFormatado}");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Método de pagamento escolhido: Cartão de Crédito:");
                                Console.WriteLine("Escreva o número de parcelas: ");
                                int parcelas = Convert.ToInt32(Console.ReadLine());
                                compras.AumentoValorTotal(parcelas);
                                Console.WriteLine($"Valor total da compra: {compras.ValorTotalFormatado}");
                                Console.WriteLine($"Parcelamento {parcelas}x {(compras.ValorTotal / parcelas).ToString("C",CultureInfo.GetCultureInfo("pt-BR"))}");
                                break;
                            }
                        default:
                            Console.WriteLine("Método de pagamento não identificado, insira novamente");
                            break;
                    }
                    if (formaPagamento >= 1 && formaPagamento <= 3)
                        break;
                }


            }
            catch (FormatException ex)
            {
                throw new Exception($"Valor inserido no formato inválido: {ex.Message})");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message})");
            }

        }
    }
}
