//2. (Calculadora)Implemente uma calculadora básica. O usuário deve informar o primeiro operando,
//depois disso a operação (+, -, * ou /) e depois disso o segundo operando. (nível 1)

float n1 = float.Parse(Console.ReadLine());

string operador = Console.ReadLine();

float n2 = float.Parse(Console.ReadLine());

switch (operador)
{
    case ("+"):
        Console.WriteLine(n1 + n2);
        break;
    case ("-"):
        Console.WriteLine(n1 - n2);
        break;
    case ("*"):
        Console.WriteLine(n1 * n2);
        break;
    case ("/"):
        Console.WriteLine(n1 / n2);
        break;
}