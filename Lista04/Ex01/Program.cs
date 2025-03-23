//1. (Média de idade - Número de alunos fixo(5 alunos)) Implemente
//um programa que leia a idade de 5 usuários e calcule a média de idade.
//Ordem dos dados de entrada: Idade 1 / Idade 2 / Idade 3 / Idade 4 / Idade 5

int[] idades = new int[5];

for(int indexIdade = 0; indexIdade < 5;indexIdade++)
{
    idades[indexIdade] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(idades.Average());