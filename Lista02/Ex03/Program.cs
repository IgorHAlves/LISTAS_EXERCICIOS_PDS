//3. (Ordenação crescente) Implemente um programa que receba do usuário três números e ordene-os do menor para o maior. (nível 2)

int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

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
