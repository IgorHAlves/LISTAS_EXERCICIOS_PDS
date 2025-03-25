//6. (Etanol ou gasolina - consumo real) Incremente o exercício 5 (Etanol ou Gasolina - 70%),
//de forma a ler o consumo de combustível do carro e não mais considerar a regra de 70%. (nível 3)

decimal etanol = decimal.Parse(Console.ReadLine());
float consumoEtanol = float.Parse(Console.ReadLine());
decimal gasolina = decimal.Parse(Console.ReadLine());
float consumoGasolina = float.Parse(Console.ReadLine());

float litrosEtanol = consumoEtanol / (float)etanol;
float litrosGasolina = consumoGasolina / (float)gasolina;


if (litrosEtanol > litrosGasolina)
{
    Console.WriteLine("Etanol");
}
else if (litrosEtanol < litrosGasolina)
{
    Console.WriteLine("Gasolina");
}
else
{
    Console.WriteLine("Empate");
}