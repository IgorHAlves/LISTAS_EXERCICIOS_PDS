//8.(Notas com aprovação, sub e exame) Incremente o exercício 1, incluindo a possibilidade de prova substitutiva e exame.
//Substitutiva: Caso o aluno não seja aprovado direto, pergunte se ele quer fazer substitutiva (S / N), caso ele opte, leia a nota dele e use essa nota para substituir a menor nota.
//Exame: Caso após a sub o aluno esteja de exame, leia a nota de exame e calcule a nota final.
//Cálculo: (((Nota1 + Nota2) / 2) + Exame) / 2.Para aprovação final, essa nota deve ser maior que 5.

//Ordem das entradas: Nota 1 / Nota 2 / Decisão sobre sub (caso elegível) / Nota sub (caso tenha escolhido fazer sub) / Nota exame (caso elegível) (nível 5)

float entrada1 = float.Parse(Console.ReadLine());

float n1 = entrada1 <= 10 && entrada1 >= 0 ? entrada1 : 0;

float entrada2 = float.Parse(Console.ReadLine());

float n2 = entrada1 <= 10 && entrada1 >= 0 ? entrada2 : 0;

float media = (n1 + n2) / 2;

const int aprovacao = 7;

const int minima = 4;

char substitutiva;

//aprovado direto
if (media >= aprovacao)
{
    Console.WriteLine($"{media:f2} - Aprovado");
}
//exame
else if (media >= minima)
{
    Console.WriteLine($"{media:f2} - Exame");
    substitutiva = char.Parse(Console.ReadLine());
    //quis fazer sub
    if (substitutiva == 'S')
    {
        float notaSubstitutiva = float.Parse(Console.ReadLine());

        if (n1 > n2)
            n2 = notaSubstitutiva;

        else
            n1 = notaSubstitutiva;

        media = (n1 + n2) / 2;
        //aprovado na sub
        if (media >= aprovacao)
            Console.WriteLine($"{media:f2} - Aprovado");
        else if (media >= minima)
        {
            //Exame na sub
            Console.WriteLine($"{media:f2} - Exame");
            float notaExame = float.Parse(Console.ReadLine());
            float notaFinal = (media + notaExame) / 2;
            //Passou no exame que pegou com a sub
            if (notaFinal >= 5)
            {
                Console.WriteLine($"{notaFinal:f2} - Aprovado");
            }
            //Não passou no exame que pegou com a sub
            else
                Console.WriteLine($"{notaFinal:f2} - Reprovado");
        }
    }
    //Pegou exame mas nao quis fazer a sub
    else
    {
        float notaExame = float.Parse(Console.ReadLine());
        float notaFinal = (media + notaExame) / 2;
        //Passou no exame
        if (notaFinal >= 5)
        {
            Console.WriteLine($"{notaFinal:f2} - Aprovado");
        }
        //Não passou no exame
        else
            Console.WriteLine($"{notaFinal:f2} - Reprovado");
    }
}
else
{
    Console.WriteLine($"{media:f2} - Reprovado");
    substitutiva = char.Parse(Console.ReadLine());
    //quis fazer sub
    if (substitutiva == 'S')
    {
        float notaSubstitutiva = float.Parse(Console.ReadLine());

        if (n1 > n2)
            n2 = notaSubstitutiva;

        else
            n1 = notaSubstitutiva;

        media = (n1 + n2) / 2;
        //aprovado na sub
        if (media >= aprovacao)
            Console.WriteLine($"{media:f2} - Aprovado");
        else if (media >= minima)
        {
            //Exame na sub
            Console.WriteLine($"{media:f2} - Exame");
            float notaExame = float.Parse(Console.ReadLine());
            float notaFinal = (media + notaExame) / 2;
            //Passou no exame que pegou com a sub
            if (notaFinal >= 5)
            {
                Console.WriteLine($"{notaFinal:f2} - Aprovado");
            }
            //Não passou no exame que pegou com a sub
            else
                Console.WriteLine($"{notaFinal:f2} - Reprovado");
        }
        else
            Console.WriteLine($"{media:f2} - Reprovado");
    }
}