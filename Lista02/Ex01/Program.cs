//1. (Média e aprovação) Escreva um programa que receba duas notas e calcule a média final. As notas devem ser de 0 a 10. Calcule a situação de aprovação do aluno com base no seguinte critério:
//Nota >= 7 → Aprovado
//Nota < 7 e >= 4 → Exame
//Nota < 4 → Reprovado A nota de aprovação (7) e a nota mínima (4) devem ser valores imutáveis no programa. (nível 1)

float entrada1 = float.Parse(Console.ReadLine());

float n1 = entrada1 <= 10 && entrada1 >= 0 ? entrada1 : 0;

float entrada2 = float.Parse(Console.ReadLine());

float n2 = entrada1 <= 10 && entrada1 >= 0 ? entrada2 : 0;

float media = (n1 + n2) / 2;

const int aprovacao = 7;

const int minima = 4;

if (media >= aprovacao)
    Console.WriteLine($"{media:f2} - Aprovado");
else if (media >= minima)
    Console.WriteLine($"{media:f2} - Exame");
else if (media < minima)
    Console.WriteLine($"{media:f2} - Reprovado");