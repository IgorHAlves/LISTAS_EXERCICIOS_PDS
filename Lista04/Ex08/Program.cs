//8. (Contagem de vogais) Implemente um programa que conte o
//número de cada uma das vogais em uma frase informada pelo usuário.
//Ordem dos dados de entrada: Frase

int contadorDeVogais = 0;

char[] vogais = new char[5];

vogais[0] = 'a';
vogais[1] = 'e';
vogais[2] = 'i';
vogais[3] = 'o';
vogais[4] = 'u';

string frase = Console.ReadLine();

for(int indexLetra = 0; indexLetra < frase.Length; indexLetra++)
{
    foreach(char vogal in vogais)
    {
        if(vogal == frase[indexLetra])
        {
            contadorDeVogais++;
        }
    }
}

Console.WriteLine($"Na frase há {contadorDeVogais} vogais");