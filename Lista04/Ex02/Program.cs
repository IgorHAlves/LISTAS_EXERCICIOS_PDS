//2. (Preços de produtos - Número de produtos fixo(3 produtos))
//Implemente um programa que leia o preço de 3 produtos e faça a soma
//desses produtos.
//Ordem dos dados de entrada: Preço do produto 1 / Preço do produto 2 / Preço do
//produto 3

int[] precos = new int[3];

for(int preco = 0; preco<3; preco++)
{
    precos[preco] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(precos.Sum());
