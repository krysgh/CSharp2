// See https://aka.ms/new-console-template for more information


using AtendimentoBanco;

Fila f = new Fila();

int opcaoMenu,tipoCliente;

do
{
    do
    {
        Console.Write("1 - Adicionar cliente\n2 - Atender próximo cliente\n3 - Mostrar filas\n0 - Sair\n\nDigite a opção desejada: ");
        opcaoMenu = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcaoMenu)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                break;
            case 1:
                do
                {
                    Console.Write("ADICIONAR CLENTE\n\n1 - Comum\n2 - Prioritário\n\nDigite a opção desejada: ");
                    tipoCliente = Convert.ToInt32(Console.ReadLine());

                    if(tipoCliente == 1)
                    {

                    }
                    else if(tipoCliente == 2)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Insira uma opção válida!");
                    }
                }while(tipoCliente < 1 || tipoCliente > 2);
                
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Insira uma opção válida!");
                break;
        }

        Console.WriteLine();

    } while (opcaoMenu < 0 || opcaoMenu > 3);
} while (opcaoMenu != 0);
