// See https://aka.ms/new-console-template for more information

using AtendimentoBancoEmSala;

Console.WriteLine("Fila do Banco: ");
Banco banco = new Banco();
int op;


void MostrarFila()
{
    Console.WriteLine("FILA PRIORITARIA");
    banco.FilaPrioritaria.MostrarFila();
    Console.WriteLine("FILA COMUM");
    banco.FilaNormal.MostrarFila();
}

do
{


    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Atender");
    Console.WriteLine("3 - Mostrar Fila");
    Console.WriteLine("4 - Sair");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Informe o nome do cliente");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe a idade do cliente");
            int idade = int.Parse(Console.ReadLine()!);

            Cliente c = new(nome, idade);

            if (c.EhPrioritario)
                banco.FilaNormal.Enfileirar(c);
            else
                banco.FilaPrioritaria.Enfileirar(c);
            MostrarFila();
                break;
        case 2:
            c = banco.AtenderCliente();
            if (c is null)
                Console.WriteLine("Nenhum cliente na fila");
            else
                Console.WriteLine(c.ToString()!);
            MostrarFila();
            break;
        case 3:
            MostrarFila();
            break;
        case 4:
            break;
        default:
            break;

    }

} while (op != 4);