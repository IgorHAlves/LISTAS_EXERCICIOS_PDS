//3. (Formatação de data) Implemente um programa que com base em
//um dia, mês e ano informados pelo usuário, exiba a data completa - dia
//exibido com 2 dígitos e mês informado pelo nome.

int dia = Convert.ToInt32(Console.ReadLine());

int mes = Convert.ToInt32(Console.ReadLine());

int ano = Convert.ToInt32(Console.ReadLine());

string mesExtenso;

switch (mes)
{
    case (1):
        Console.WriteLine($"{dia:D2} de janeiro de {ano}");
        break;

    case (2):
        Console.WriteLine($"{dia:D2} de fevereiro de {ano}");
        break;

    case (3):
        Console.WriteLine($"{dia:D2} de março de {ano}");
        break;

    case (4):
        Console.WriteLine($"{dia:D2} de abril de {ano}");
        break;

    case (5):
        Console.WriteLine($"{dia:D2} de maio de {ano}");
        break;

    case (6):
        Console.WriteLine($"{dia:D2} de junho de {ano}");
        break;

    case (7):
        Console.WriteLine($"{dia:D2} de julho de {ano}");
        break;

    case (8):
        Console.WriteLine($"{dia:D2} de agosto de {ano}");
        break;

    case (9):
        Console.WriteLine($"{dia:D2} de setembro de {ano}");
        break;

    case (10):
        Console.WriteLine($"{dia:D2} de outubro de {ano}");
        break;

    case (11):
        Console.WriteLine($"{dia:D2} de novembro de {ano}");
        break;

    case (12):
        Console.WriteLine($"{dia:D2} de dezembro de {ano}");
        break;

    default:
        Console.WriteLine("Data inválida");
        break;
}