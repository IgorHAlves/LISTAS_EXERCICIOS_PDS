//2. (Ano bissexto) Implemente um programa que receba do usuário um
//ano e informe se este ano é bissexto ou não. Um ano é bissexto se for
//divisível por 4, mas não por 100. Um ano também é bissexto se for
//divisível por 400.

int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
{
    Console.WriteLine("Bissexto");
}
else
{
    Console.WriteLine("Não bissexto");
}