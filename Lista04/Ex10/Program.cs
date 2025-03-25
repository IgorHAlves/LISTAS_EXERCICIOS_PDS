//10. (Caixa de supermercado - Número de produtos variável).
//Incremente o exercício Caixa supermercado - Forma de pagamento da Lista
//de Exercícios 3, de forma que: Não mais usar apenas 3 produtos, mas é
//o usuário que deve informar o número de produtos.
//Ordem dos dados de entrada: Quantidade de Produtos / Nome do Produto N…* /
//Valor do Produto N…* / Quantidade do Produto N…*

using System.Globalization;

Console.WriteLine("Escreva a quantidade de produtos desejada");

int produtos =  Convert.ToInt32(Console.ReadLine());

string[] nomesProdutos = new string[produtos];

decimal[] precosProdutos = new decimal[produtos];

int[] quantidadesProdutos = new int[produtos];

for(int indexProduto = 0; indexProduto < produtos; indexProduto++)
{
    Console.WriteLine($"Informe o nome do produto {indexProduto+1}");
    nomesProdutos[indexProduto] = Console.ReadLine();
    Console.WriteLine($"Informe o preco do produto {indexProduto+1}");
    precosProdutos[indexProduto] += decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Informe a quantidade do produto {indexProduto+1}");
    quantidadesProdutos[indexProduto] = Convert.ToInt32(Console.ReadLine());
}

decimal total = 0;

for (int indexProduto = 0; indexProduto < produtos; indexProduto++)
{
    total += precosProdutos[indexProduto] * quantidadesProdutos[indexProduto];
}

Console.WriteLine($"Total: {total.ToString("C",CultureInfo.GetCultureInfo("pt-BR"))}");

for(int indexProduto = 0;indexProduto < produtos;indexProduto++)
{
    Console.WriteLine($"{quantidadesProdutos[indexProduto]}x {nomesProdutos[indexProduto]} {(precosProdutos[indexProduto] * quantidadesProdutos[indexProduto]).ToString("C",CultureInfo.GetCultureInfo("pt-BR"))}");
}

string formaPagamento = Console.ReadLine();

switch (formaPagamento)
{
    case ("P"):
        total *= 0.93m;
        Console.WriteLine($"Valor final: {total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("D"):
        total *= 0.95m;
        Console.WriteLine($"Valor final: {total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("CC"):
        int parcelas = Convert.ToInt32(Console.ReadLine());

        if (parcelas > 10)
            total *= 1.07m;
        else if (parcelas > 5)
            total *= 1.05m;


        decimal valorParcelas = total / parcelas;
        Console.WriteLine($"Valor final: {total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} em {parcelas} parcelas de {valorParcelas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("CD"):
        Console.WriteLine($"Valor final: {total.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;
}