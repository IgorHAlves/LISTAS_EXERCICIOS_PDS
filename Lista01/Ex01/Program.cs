//1. (Notas como conceito) Implemente um programa que faça uma
//conversão de notas para conceitos (MB - Muito bom, B - Bom, R -
//Regular, I - Insatisfatório)
//Tabela de equivalência
//● MB - 9 ou acima
//● B - Entre 7 e 8,99
//● R - Entre 5 e 6,99
//● I - Abaixo de 5

float nota = float.Parse(Console.ReadLine());

if (nota >= 9)
{
    Console.WriteLine("MB");
}
else if (nota >= 7)
{
    Console.WriteLine("B");
}
else if (nota >= 5)
{
    Console.WriteLine("R");
}
else
{
    Console.WriteLine("I");
}