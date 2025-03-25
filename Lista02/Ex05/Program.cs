//5. (Etanol ou Gasolina - 70%) Implemente um programa para ler o preço do litro dos combustíveis (etanol e gasolina)
//e comparar qual o melhor combustível com base na economia. O etanol vale a pena quando custar até 70% do valor da gasolina. (nível 2)

decimal etanol = decimal.Parse(Console.ReadLine());
decimal gasolina = decimal.Parse(Console.ReadLine());

if ((etanol / gasolina) > 0.7m)
{
    Console.WriteLine("Gasolina");
}
else
{
    Console.WriteLine("Etanol");
}