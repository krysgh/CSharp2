// See https://aka.ms/new-console-template for more information
using UndoTarefa;

EditorTexto editorTexto = new EditorTexto();
int opcao;

do
{
    Console.Write("1 - Digitar novo texto\n2 - Desfazer última ação\n3 - Mostrar histórico\n4 - Sair\n\nDigite a opção desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.Write("Digite um novo texto: ");
            editorTexto.Digitar(Console.ReadLine()!);
            break;
        case 2:
            Console.WriteLine($"{editorTexto.historico.Topo()} foi removido!");
            editorTexto.Desfazer();
            break;
        case 3:
            editorTexto.MostrarHistorico();
            break;
        case 4:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Digite uma opção válida!");         
            break;
    }
    Console.ReadKey();
    Console.Clear();

} while (opcao != 4);