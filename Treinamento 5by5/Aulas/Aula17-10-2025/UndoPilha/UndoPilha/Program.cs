// See https://aka.ms/new-console-template for more information


using UndoPilha;

EditorTexto editorTexto = new EditorTexto();
int opcao;

do
{
    Console.Write("1 - Digitar novo texto\n2 - Desfazer última ação\n3 - Mostrar histórico\n4 - Mostrar 10 últimos Ctrl + Z\n5 - Sair\n\nDigite a opção desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.Write("Digite um novo texto: ");
            editorTexto.Digitar(new NoCtrlZ(Console.ReadLine()!));
            break;
        case 2:
            Console.WriteLine($"{editorTexto.historico.Topo()} foi removido!");
            editorTexto.Desfazer();
            break;
        case 3:
            editorTexto.MostrarHistorico();
            break;
        case 4:
            editorTexto.MostrarPilha();
            break;
        case 5:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Digite uma opção válida!");
            break;
    }
    Console.ReadKey();
    Console.Clear();

} while (opcao != 5);