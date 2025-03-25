//11. (Alunos identificados, média de idades, mais novo e mais velho)
//Incremente o programa Menor e maior idade entre os alunos e além de ler a
//idade dos alunos, leia o nome de cada um dos alunos e no momento de
//exibir o mais novo e o mais velho, informe o nome e também a
//respectiva idade.
//Ordem dos dados de entrada: Nome 1 / Idade 1 / Nome 2 / Idade 2 / Nome 3 / Idade
//3 / Nome 4 / Idade 4 / Nome 5 / Idade 5

int[] idades = new int[5];

string[] nomes = new string[5];

for (int indexAluno = 0; indexAluno < idades.Length; indexAluno++)
{
    idades[indexAluno] = Convert.ToInt32(Console.ReadLine());
    nomes[indexAluno] = Console.ReadLine();
}

for(int indexAluno = 0;indexAluno < nomes.Length; indexAluno++)
{
    if (idades[indexAluno] == idades.Min())
    {
        Console.WriteLine("Menor idade: ");
        Console.WriteLine($"{idades.Min()}");
        Console.WriteLine("Nome:");
        Console.WriteLine($"{nomes[indexAluno]}");
        Console.WriteLine("-----------------");
    }
    else if (idades[indexAluno] == idades.Max())
    {
        Console.WriteLine("Maior idade: ");
        Console.WriteLine($"{idades.Max()}");
        Console.WriteLine("Nome");
        Console.WriteLine($"{nomes[indexAluno]}");
        Console.WriteLine("-----------------");
    }

}