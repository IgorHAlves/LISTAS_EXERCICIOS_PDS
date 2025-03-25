//9. (Contagem de frequência de números).Implemente um programa
//que gere um array de 5 posições, contendo valores aleatórios entre 1 e
//5. Depois disso, exiba os números sorteados, e para os números de 1 a
//5, conte quantas vezes cada um destes números apareceram no array.
//Para submissão no Skurge, leia do usuário a semente para a aleatoriedade.
//Ordem dos dados de entrada: Semente para aleatoriedade

Random random = new Random();

int[] valoresAleatorios = new int[5];

for (int indexValor = 0; indexValor < valoresAleatorios.Length; indexValor++)
{
    valoresAleatorios[indexValor] = random.Next(1, 6);
}

int[] valoresContados = new int[5];
int contadorIndexContados = 0;

foreach (int valor in valoresAleatorios)
{
    if (!valoresContados.Contains(valor))
    {
        Console.WriteLine($"O valor {valor} aparece {valoresAleatorios.Count(x => x == valor)} vezes");
        valoresContados[contadorIndexContados] = valor;

        contadorIndexContados++;
    }

}



