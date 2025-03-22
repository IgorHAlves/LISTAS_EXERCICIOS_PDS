using System.Globalization;

string nomeProduto1 = Console.ReadLine();

decimal valorProduto1 = decimal.Parse(Console.ReadLine());

int quantidadeProduto1 = Convert.ToInt32(Console.ReadLine());

string nomeProduto2 = Console.ReadLine();

decimal valorProduto2 = decimal.Parse(Console.ReadLine());

int quantidadeProduto2 = Convert.ToInt32(Console.ReadLine());

string nomeProduto3 = Console.ReadLine();

decimal valorProduto3 = decimal.Parse(Console.ReadLine());

int quantidadeProduto3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($@"
Total: {(valorProduto1 * quantidadeProduto1 + valorProduto2 * quantidadeProduto2 + valorProduto3 * quantidadeProduto3).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - {quantidadeProduto1}x {nomeProduto1} - {(valorProduto1 * quantidadeProduto1).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - {quantidadeProduto2}x {nomeProduto2} - {(valorProduto2 * quantidadeProduto2).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - {quantidadeProduto3}x {nomeProduto3} - {(valorProduto3 * quantidadeProduto3).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");


string formaPagamento = Console.ReadLine();

decimal valorfinal = valorProduto1 * quantidadeProduto1 + valorProduto2 * quantidadeProduto2 + valorProduto3 * quantidadeProduto3;



switch (formaPagamento)
{
    case ("P"):
        valorfinal *= 0.93m;
        Console.WriteLine($"Valor final: {valorfinal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("D"):
        valorfinal *= 0.95m;
        Console.WriteLine($"Valor final: {valorfinal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("CC"):
        int parcelas = Convert.ToInt32(Console.ReadLine());

        if (parcelas > 10)
            valorfinal *= 1.07m;
        else if (parcelas > 5)
            valorfinal *= 1.05m;


        decimal valorParcelas = valorfinal / parcelas;
        Console.WriteLine($"Valor final: {valorfinal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} em {parcelas} parcelas de {valorParcelas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;

    case ("CD"):
        Console.WriteLine($"Valor final: {valorfinal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}");
        break;
}