//4. (Calculadora fatorial) Implemente uma calculadora fatorial. O
//usuário deve informar o número a ser calculado e o programa deve
//calcular o número fatorial daquele número e no final exibir o número que
//foi calculado e o resultado final.
//Ordem dos dados de entrada: Número a calcular o fatorial


int numeroFatorial = Convert.ToInt32(Console.ReadLine());

int[] arrayFatorial = new int[numeroFatorial];

int fatorial = 1;

for(int index = 0; index < arrayFatorial.Length;index++)
{
    arrayFatorial[index] = numeroFatorial;
    numeroFatorial--;
}

for(int index = 0; index < arrayFatorial.Length;index++)
{
    fatorial *= arrayFatorial[index];
}

Console.WriteLine(fatorial);