//7. (Financiamento e quitação) Incremente o Exercício 11 da Lista de Exercícios 01 (financiamento).
//Caso o usuário tenha pago pelo menos 50% do valor total, ofereça uma opção de quitação do financiamento com 5% de desconto para o pagamento à vista.
//Caso o usuário tenha pago pelo menos 25% do valor total, ofereça uma opção de quitação do financiamento com 10% de desconto para o pagamento à vista.
//Exiba o valor que o usuário economizaria escolhendo quitar o financiamento. (nível 4)

using System.Globalization;

decimal totalFinanciamento = Convert.ToDecimal(Console.ReadLine());
decimal totalParcelas = Convert.ToDecimal(Console.ReadLine());
decimal parcelasPagas = Convert.ToDecimal(Console.ReadLine());


decimal parcelaMensal = (totalFinanciamento / totalParcelas);

decimal porcentagemPago = (parcelasPagas / totalParcelas) * 100;

decimal valorAPagar = parcelaMensal * (totalParcelas - parcelasPagas);

decimal oferta;
int desconto;
if (porcentagemPago >= 50)
{
    oferta = valorAPagar * 0.05m;
    desconto = 5;
}
else if (porcentagemPago >= 25)
{
    oferta = valorAPagar * 0.1m;
    desconto = 10;

}
else
{
    oferta = 0;
    desconto = 0;
}

string mensagem;
if (oferta != 0)
{
    mensagem = (@$"Resumo do financiamento
 - Parcela mensal: {parcelaMensal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Valor total pago: {(parcelaMensal * parcelasPagas).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} | Valor a pagar: {valorAPagar.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Valor total: {totalFinanciamento.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Progresso: {parcelasPagas} / {totalParcelas} ({porcentagemPago:f2}%) de parcelas pagas - {totalParcelas - parcelasPagas} parcelas a pagar

 Oferta: Você economizaria {oferta.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} com o pagamento à vista com {desconto}% de desconto");
}
else
{
    mensagem = (@$"Resumo do financiamento
 - Parcela mensal: {parcelaMensal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Valor total pago: {(parcelaMensal * parcelasPagas).ToString("C", CultureInfo.GetCultureInfo("pt-BR"))} | Valor a pagar: {valorAPagar.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Valor total: {totalFinanciamento.ToString("C", CultureInfo.GetCultureInfo("pt-BR"))}
 - Progresso: {parcelasPagas} / {totalParcelas} ({porcentagemPago:f2}%) de parcelas pagas - {totalParcelas - parcelasPagas} parcelas a pagar");
}

Console.WriteLine(mensagem);