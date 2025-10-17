// See https://aka.ms/new-console-template for more information


using PilhaRoupa;

PilhaDeRoupas pilha = new PilhaDeRoupas();
int op;




do
{


    Console.WriteLine("1 - Adicionar");
    Console.WriteLine("2 - Remover");
    Console.WriteLine("3 - Mostrar Pilha");
    Console.WriteLine("4 - Sair");
    op = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (op)
    {
        case 1:
            Console.WriteLine("Informe o nome da roupa");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe a descrição da roupa");
            string descricao = Console.ReadLine()!;

            Roupa r = new(nome, descricao);

            pilha.Meias.Push(r);
            pilha.Meias.showStack();

            Console.Clear();
            break;
        case 2:
            r = pilha.Meias.Pop();
            if (r is null)
                Console.WriteLine("Nenhum cliente na pilha");
            else
                Console.WriteLine(r.ToString()!);
            pilha.Meias.showStack();
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            pilha.Meias.showStack();
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            break;

    }

} while (op != 4);