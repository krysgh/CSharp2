// See https://aka.ms/new-console-template for more information

string jogador1, jogador2;
int RodadaAtual = 1;
bool vitoria = false;

void IdentificarJogador(string nome1, string nome2)
{
    jogador1 = nome1;
    jogador2 = nome2;
}

char[,] CriarJogo()
{
    char[,] Tabuleiro = new char[3, 3];
    int contador = 1;

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Tabuleiro[i, j] = Convert.ToChar(contador.ToString());
            contador++;
        }
    }

    ExibirJogo(Tabuleiro);

    return Tabuleiro;
}

void ExibirJogo(char[,] Tabuleiro)
{
    Console.Clear();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(Tabuleiro[i, j] + " ");
            if (j < 2)
            {
                Console.Write("| ");
            }
        }
        if (i < 2)
        {
            Console.WriteLine("\n---------");
        }

    }
}

char[,] InserirJogada(char[,] Tabuleiro)
{
    ExibirJogo(Tabuleiro);

    if (RodadaAtual % 2 != 0)
        Console.WriteLine($"\n\nVez do jogador 1 - {jogador1} (X)");
    else
        Console.WriteLine($"\n\nVez do jogador 2 - {jogador2} (O)");

    char Posicao;

    do
    {
        Console.WriteLine("Informe a posição desejada:");
        Posicao = Convert.ToChar(Console.ReadLine() ?? "0");

    } while (!ValidarJogada(Tabuleiro, Posicao));

    Tabuleiro = PreencherTabuleiro(Tabuleiro, Posicao, RodadaAtual);

    RodadaAtual++;

    return Tabuleiro;
}

bool ValidarJogada(char[,] Tabuleiro, char Posicao)
{
    if (Posicao < '1' || Posicao > '9')
        return false;
    else
    {
        switch (Posicao)
        {
            case '1':
                if (Tabuleiro[0, 0] == 'X' || Tabuleiro[0, 0] == 'O')
                    return false;
                break;
            case '2':
                if (Tabuleiro[0, 1] == 'X' || Tabuleiro[0, 1] == 'O')
                    return false;
                break;
            case '3':
                if (Tabuleiro[0, 2] == 'X' || Tabuleiro[0, 2] == 'O')
                    return false;
                break;
            case '4':
                if (Tabuleiro[1, 0] == 'X' || Tabuleiro[1, 0] == 'O')
                    return false;
                break;
            case '5':
                if (Tabuleiro[1, 1] == 'X' || Tabuleiro[1, 1] == 'O')
                    return false;
                break;
            case '6':
                if (Tabuleiro[1, 2] == 'X' || Tabuleiro[1, 2] == 'O')
                    return false;
                break;
            case '7':
                if (Tabuleiro[2, 0] == 'X' || Tabuleiro[2, 0] == 'O')
                    return false;
                break;
            case '8':
                if (Tabuleiro[2, 1] == 'X' || Tabuleiro[2, 1] == 'O')
                    return false;
                break;
            case '9':
                if (Tabuleiro[2, 2] == 'X' || Tabuleiro[2, 2] == 'O')
                    return false;
                break;

            default:
                break;

        }

    }

    return true;
}

char[,] PreencherTabuleiro(char[,] Tabuleiro, char Posicao, int Jogador)
{
    for (int i = 1; i < 10; i++)
    {
        if (Convert.ToChar(i.ToString()) == Posicao)
            if (Jogador % 2 == 0)
                Tabuleiro[(i - 1) / 3, (i - 1) % 3] = 'O';
            else
                Tabuleiro[(i - 1) / 3, (i - 1) % 3] = 'X';
    }

    return Tabuleiro;
}

bool VerificarVitoria(char[,] Tabuleiro)
{
    for (int linha = 0; linha < 3; linha++)
    {
        if (Tabuleiro[linha, 0] == Tabuleiro[linha, 1] && Tabuleiro[linha, 1] == Tabuleiro[linha, 2])
            return true;
    }

    for (int coluna = 0; coluna < 3; coluna++)
    {
        if (Tabuleiro[0, coluna] == Tabuleiro[1, coluna] && Tabuleiro[1, coluna] == Tabuleiro[2, coluna])
            return true;
    }

    if (Tabuleiro[0, 0] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[2, 2])
        return true;

    if (Tabuleiro[0, 2] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[2, 0])
        return true;


    return false;
}

void ExibirVitoria(char[,] Tabuleiro)
{
    if ((!VerificarVitoria(Tabuleiro)) || RodadaAtual > 9)
    {
        Console.WriteLine("Ninguém ganhou!");
    }
    else if (VerificarVitoria(Tabuleiro))
    {

        if (RodadaAtual % 2 == 0)
            Console.WriteLine($"\n\nJogador 1 - {jogador1} (X) ganhou!");
        else
            Console.WriteLine($"\n\nJogador 2 - {jogador2} (O) ganhou!");


    }
}



int op;
do
{
    Console.Clear();

    Console.WriteLine("Informe o nome do primeiro jogador: ");
    string nome1 = Console.ReadLine() ?? "Jogador 1";
    Console.WriteLine("Informe o nome do segundo jogador: ");
    string nome2 = Console.ReadLine() ?? "Jogador 2";

    IdentificarJogador(nome1, nome2);

    char[,] jogo = CriarJogo();

    do
    {
        jogo = InserirJogada(jogo);

        if (RodadaAtual >= 5)
            vitoria = VerificarVitoria(jogo);

    } while (!vitoria && RodadaAtual < 10);

    ExibirJogo(jogo);
    ExibirVitoria(jogo);
    RodadaAtual = 1;

    Console.WriteLine("\nDeseja Recomeçar?\n1-Sim\n0-Não");
    op = Convert.ToInt32(Console.ReadLine());


} while (op != 0);