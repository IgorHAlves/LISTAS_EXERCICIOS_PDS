//4. (Ordenação com opção) Incremente o programa anterior, de forma que o usuário decida se a ordenação será crescente “C” ou decrescente “D”. (nível 2)

int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
char ordem = char.Parse(Console.ReadLine());

switch (ordem)
{
    case 'C':
        {
            if (n1 <= n2 && n1 <= n3)
            {
                if (n2 <= n3)
                    Console.WriteLine($"{n1} {n2} {n3}");
                else if (n3 < n2)
                    Console.WriteLine($"{n1} {n3} {n2}");
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                if (n1 <= n3)
                    Console.WriteLine($"{n2} {n1} {n3}");
                else if (n3 < n1)
                    Console.WriteLine($"{n2} {n3} {n1}");
            }
            else if (n3 <= n1 && n3 <= n2)
            {
                if (n1 <= n2)
                    Console.WriteLine($"{n3} {n1} {n2}");
                else if (n2 < n1)
                    Console.WriteLine($"{n3} {n2} {n1}");
            }
            break;
        }
    case 'D':
        {
            if (n1 >= n2 && n1 >= n3)
            {
                if (n2 >= n3)
                    Console.WriteLine($"{n1} {n2} {n3}");
                else if (n3 > n2)
                    Console.WriteLine($"{n1} {n3} {n2}");
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                if (n1 >= n3)
                    Console.WriteLine($"{n2} {n1} {n3}");
                else if (n3 > n1)
                    Console.WriteLine($"{n2} {n3} {n1}");
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                if (n1 >= n2)
                    Console.WriteLine($"{n3} {n1} {n2}");
                else if (n2 > n1)
                    Console.WriteLine($"{n3} {n2} {n1}");
            }
            break;
        }
}