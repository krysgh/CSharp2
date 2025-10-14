// See https://aka.ms/new-console-template for more information

using SistemaPagamentos;


void CadastrarValorData(Pagamento[] Pagamentos, int indice)
{
    Console.WriteLine($"EFETUAR PAGAMENTO {indice + 1}");

    Console.Write("Digite o valor do pagamento:");
    Pagamentos[indice].SetValor(Convert.ToDouble(Console.ReadLine()));

    Console.Write("Digite a data do pagamento:");
    Pagamentos[indice].SetDataPagamento(Convert.ToDateTime(Console.ReadLine()));

    Console.Clear();
}



Console.WriteLine("Quantos pagamentos deseja fazer?");
int qtdPagamentos = Convert.ToInt32(Console.ReadLine());

Pagamento[] Pagamentos = new Pagamento[qtdPagamentos];
Console.Clear();

int opcao;


for(int i = 0; i < qtdPagamentos; i++)
{
    do
    {
        Console.WriteLine("Digite uma forma de pagamento:\n1-Cartão de Crédito (+15%)\n2-Boleto");
        opcao = Convert.ToInt32(Console.ReadLine());

        Console.Clear();

        if (opcao == 1)
        {
            Pagamentos[i] = new PagamentoCartaoCredito();
            CadastrarValorData(Pagamentos, i);

        }
        else if (opcao == 2)
        {
            Pagamentos[i] = new PagamentoBoleto();
            CadastrarValorData(Pagamentos, i);
        }
        else
        {
            Console.WriteLine("Digite 1 ou 2");
            Console.WriteLine();
        }


    } while (opcao < 1 || opcao > 2);
}



Console.WriteLine("----------------------------------------\nPAGAMENTOS EFETUADOS\n");

for(int i = 0;i < qtdPagamentos; i++)
{
    Console.WriteLine($"Pagamento {i + 1}");
    Console.WriteLine(Pagamentos[i].ToString());
    Console.WriteLine();

}

Console.WriteLine("----------------------------------------");
