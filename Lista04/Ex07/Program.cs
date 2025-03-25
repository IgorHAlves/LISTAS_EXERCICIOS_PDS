//7. (Sorteio de alunos) Implemente um programa que leia o número de
//alunos que o usuário quer inserir no array, depois disso, leia o nome de
//cada um dos alunos, e então, sorteie um aluno entre todos os alunos
//incluídos.
//Para submissão no Skurge, leia do usuário a semente para a aleatoriedade.
//Ordem dos dados de entrada: Semente para aleatoriedade / Quantidade de alunos /
//Nome do Aluno N…*

using System.Security.AccessControl;

int quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

string[] alunos = new string[quantidadeAlunos];

for (int indexAluno = 0; indexAluno < alunos.Length; indexAluno++)
{
    alunos[indexAluno] = Console.ReadLine();
}

Random random = new Random();

int valor = random.Next(quantidadeAlunos);

Console.WriteLine(alunos[valor]);

