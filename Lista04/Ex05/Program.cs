//5. (Menor e maior idade entre os alunos) Incremente o programa
//Média de idade - Número de alunos fixo (5 alunos), de forma a identificar a
//menor e a maior idade entre os alunos.
//Ordem dos dados de entrada: Idade 1 / Idade 2 / Idade 3 / Idade 4 / Idade 5

int[] idades = new int[5];

for(int indexIdade = 0; indexIdade < idades.Length;indexIdade++)
{
    idades[indexIdade] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(idades.Min());

Console.WriteLine(idades.Max());