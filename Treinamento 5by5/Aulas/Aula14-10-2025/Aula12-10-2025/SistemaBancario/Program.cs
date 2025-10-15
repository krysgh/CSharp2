// See https://aka.ms/new-console-template for more information

using SistemaBancario;

ContaBancaria conta = new ContaBancaria();

Console.WriteLine("------------------------------\nCADASTRO DE CONTA BANCÁRIA\n");

Console.Write("Insira o titular: ");
conta.SetTitular(Console.ReadLine()!);
Console.Clear();

Console.Write("Digite o saldo da sua conta: ");
conta.SetSaldo(Convert.ToDouble(Console.ReadLine()));
Console.Clear();


int opcao;
do
{
    double saldoAtual = conta.GetSaldo();
    decimal valor;

    Console.WriteLine("Digite a opção desejada: ");
    Console.WriteLine("1-Realizar Saque");
    Console.WriteLine("2-Realizar Depósito");
    Console.WriteLine("3-Consultar Dados");
    Console.WriteLine("4-Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();


    switch (opcao)
    {
        case 1:

            double saldoPreSaque = saldoAtual;
            Console.Write("SAQUE\n\nDigite o valor a ser sacado: R$");
            valor = Convert.ToDecimal(Console.ReadLine());
            saldoAtual = conta.Sacar(valor);

            if (saldoAtual != saldoPreSaque)
                Console.WriteLine("SAQUE REALIZADO COM SUCESSO!");
            else 
                Console.WriteLine("SAQUE NÃO FOI REALIZADO!");
                Console.ReadKey();

            break;
        case 2:
            saldoAtual = conta.GetSaldo();
            Console.Write("DEPÓSITO\n\nDigite o valor a ser depositado: R$");
            valor = Convert.ToDecimal(Console.ReadLine());
            saldoAtual = conta.Depositar(valor);

            Console.WriteLine("DEPÓSITO REALIZADO COM SUCESSO!");
            Console.ReadKey();

            break;
        case 3:
            Console.WriteLine($"INFORMAÇÕES DA CONTA\n\nTitular: {conta.GetTitular()}\nSaldo Atual: {saldoAtual:F2}");

            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Insira uma opção válida.");
            break;
    }

    Console.Clear();


} while (opcao != 4);