// See https://aka.ms/new-console-template for more information
using SistemaBancario;

ContaBancaria conta = new ContaBancaria();

Console.WriteLine("-----------------------\nCADASTRO DE CONTA BANCARIA\n");

Console.Write("Insira o titular: ");
conta.SetTitular(Console.ReadLine()!);
Console.Clear();

Console.Write("Digite o saldo da sua conta: ");
conta.SetSaldo(Convert.ToDouble(Console.ReadLine()));
Console.Clear();


int opcao;
do
{
    double saldoAtual;
    int valor;

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
            saldoAtual = conta.GetSaldo();
            Console.Write("SAQUE\n\nDigite o valor a ser sacado: R$");
            valor = Convert.ToInt32(Console.ReadLine());
            saldoAtual = conta.Sacar(valor);

            Console.WriteLine("DÉPÓSITO REALIZADO COM SUCESSO!");
            Console.ReadKey();

            break;
        case 2:
            saldoAtual = conta.GetSaldo();
            Console.Write("DEPÓSITO\n\nDigite o valor a ser depositado: R$");
            valor = Convert.ToInt32(Console.ReadLine());
            saldoAtual = conta.Depositar(valor);

            break;
        case 3:
            break;
        case 4:
            break;
        default:
            break;
    }

} while (opcao != 4);


