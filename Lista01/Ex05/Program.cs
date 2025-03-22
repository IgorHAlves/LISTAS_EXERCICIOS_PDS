using System.Globalization;

int tempoPermanencia = Convert.ToInt32(Console.ReadLine());
decimal tarifa = 0;

if (tempoPermanencia <= 2)
{
    tarifa = 5m;
}
else if (tempoPermanencia <= 5)
{
    tarifa = 5m + 2 * (tempoPermanencia - 2);
}
else if (tempoPermanencia > 5)
{
    tarifa = 10m + 1.5m * (tempoPermanencia - 5);
}

Console.WriteLine($"{tarifa.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");