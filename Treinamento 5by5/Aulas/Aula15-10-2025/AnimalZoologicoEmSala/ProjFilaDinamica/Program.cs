// See https://aka.ms/new-console-template for more information

using ProjFilaDinamica;
using System.Globalization;

Fila f = new Fila();

int opcao;

do
{
    do
    {
        Console.Write("1 - Adicionar Pessoa\n2 - Remover última Pessoa\n3 - Exibir Fila\n4 - Exibir tamanho da fila\n5 - Encerrar Programa\n\nDigite a opção desejada: ");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
            case 1:
                Console.Write("ADICIONAR PESSOA\n\nDigite o nome da pessoa: ");
                f.InserirPessoa(new Pessoa(Console.ReadLine()!), f.Head, f.Tail);
                break;
            case 2:
                f.RemoverPessoa(f.Head, f.Tail);
                break;
            case 3:
                Console.WriteLine("FILA IMPRESSA\n");
                f.ImprimirFila(f.Head);
                break;
            case 4:
                Console.WriteLine("TAMANHO DA FILA\n");
                Console.Write($"Há {Convert.ToInt32(f.TamanhoFila(f.Head))} pessoa(s) na fila.\n");
                break;
            case 5:
                Console.WriteLine("Saindo do programa...");
                break;
            default:
                Console.WriteLine("Insira uma opção válida!");             
                break;
        }

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------\n");

    } while (opcao < 1 || opcao > 5);
} while (opcao != 5);
