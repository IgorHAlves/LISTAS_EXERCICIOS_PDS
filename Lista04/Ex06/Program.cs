//6. (Preços de produtos - Número de produtos variável) Implemente
//um programa que leia o número de produtos que o usuário quer digitar
//(X), depois disso, leia o preço de X produtos (a quantidade que o
//usuário solicitou) e faça a soma desses produtos.
//Ordem dos dados de entrada: Quantidade de produtos / Preço do produto N…*

int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

decimal[] precoProdutos = new decimal[quantidadeProdutos];

for(int indexPrecoProdutos = 0; indexPrecoProdutos < quantidadeProdutos;indexPrecoProdutos++)
{
    Console.WriteLine($"Preço do produto numero {indexPrecoProdutos+1}");
    precoProdutos[indexPrecoProdutos] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine($"Soma dos preços: {precoProdutos.Sum()}");

