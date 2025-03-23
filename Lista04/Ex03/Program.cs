//3. (Exibição do nome de trás para frente) Implemente um programa
//que leia o nome do usuário e exiba este nome escrito de trás para
//frente.
//Ordem dos dados de entrada: Nome do usuário


string nome = Console.ReadLine();

string nomeAoContrario = "";

for (int indexLetra = nome.Length - 1; indexLetra >= 0; indexLetra--)
{
    nomeAoContrario += nome[indexLetra];
}

Console.WriteLine(nomeAoContrario);