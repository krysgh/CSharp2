// See https://aka.ms/new-console-template for more information

using SistemaPagamentoEmSala;

Console.WriteLine("Informe o valor a ser pago:");
var valor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe a forma de pagamento (1 - Boleto / 2 - Cartão de Crédito):");
var formaPagmento = Convert.ToInt32(Console.ReadLine());

if( formaPagmento == 1)
{
    var pagamento = new PagamentoBoleto();
    pagamento.ProcessarPagamento(valor, DateTime.Now);
}
else if(formaPagmento == 2)
{
    var pagamento = new PagamentoCartaoDeCredito();
    pagamento.ProcessarPagamento(valor, DateTime.Now);
}
else
{
    Console.WriteLine("Forma de pagamento inválida!");
}