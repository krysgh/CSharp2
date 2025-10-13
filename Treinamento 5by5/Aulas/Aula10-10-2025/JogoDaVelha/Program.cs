// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

const int LinhasTotal = 3;
const int ColunasTotal = 3;

bool JogoEncerrado = false;
int VitoriasJogador1 = 0, VitoriasJogador2 = 0, EmpatesJogadores = 0;
int VitoriasPVC = 0, DerrotasPVC = 0, EmpatesPVC = 0;

char[,] Tabuleiro =
    {
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' },
        { ' ', ' ', ' ' }
    };


void ExibirMenuPrincipal()
{
    Console.WriteLine("-----------------------------\nMENU PRINCIPAL\n");
    Console.WriteLine("1.Jogador 1 VS Jogador 2");
    Console.WriteLine("2.Jogador VS Computador");
    Console.WriteLine("3.Encerrar Programa");
    Console.WriteLine("\nDigite a opção desejada: ");
}

void ExibirMenuPVP()
{
    Console.WriteLine("------------------------------\nMODO JOGADOR 1 VS JOGADOR\n");
    Console.WriteLine("1.Iniciar Jogo");
    Console.WriteLine("2.Histórico de rodadas");
    Console.WriteLine("3.Placar Geral");
    Console.WriteLine("4.Voltar");
    Console.WriteLine("\nDigite a opção desejada: ");
}
void ExibirMenuPVC()
{
    Console.WriteLine("------------------------------\nMODO JOGADOR VS COMPUTADOR\n");
    Console.WriteLine("1.Iniciar Jogo");
    Console.WriteLine("2.Histórico de rodadas");
    Console.WriteLine("3.Placar Geral");
    Console.WriteLine("4.Voltar");
    Console.WriteLine("\nDigite a opção desejada: ");
}

void ExibirTabuleiro(char[,] Tabuleiro, int Linhas, int Colunas)
{
    Console.WriteLine("--------------------------------\nTABULEIRO ATUAL\n");
    for (int ReferenciaLinha = 0; ReferenciaLinha < Linhas; ReferenciaLinha++)
    {
        for (int ReferenciaColuna = 0; ReferenciaColuna < Colunas; ReferenciaColuna++)
        {
            char Simbolo = Tabuleiro[ReferenciaLinha, ReferenciaColuna];

            if (Simbolo == 'X')
                Console.ForegroundColor = ConsoleColor.Green;
            else if (Simbolo == 'O')
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ResetColor();


            if (ReferenciaColuna != Colunas - 1)
            {
                Console.Write($" {Tabuleiro[ReferenciaLinha, ReferenciaColuna]}");
                Console.ResetColor();
                Console.Write(" |");
            }
                
            else
            {
                Console.Write($" {Tabuleiro[ReferenciaLinha, ReferenciaColuna]}");
            }
                
        }

        Console.ResetColor();

        if (ReferenciaLinha != Linhas - 1)
            Console.WriteLine("\n---+---+---");

    }
    Console.WriteLine("\n");
}

bool ValidarLinhaTabuleiro(int Linha)
{
    return Linha >= 0 && Linha < LinhasTotal ;
}

bool ValidarColunaTabuleiro(int Coluna)
{
    return Coluna >= 0 && Coluna < ColunasTotal;
}

bool ValidarPosicaoTabuleiro(char[,] Tabuleiro, int Linha, int Coluna)
{
    return Tabuleiro[Linha, Coluna] == ' ';
}
char[,] InserirSimbolo(char[,] Tabuleiro, char Simbolo)
{
    int Linha, Coluna;

    while (true)
    {
        Console.WriteLine("Insira a posição a ser jogada. ");
        Console.Write("Linha: ");
        
        Linha = Convert.ToInt32(Console.ReadLine());

        if (!ValidarLinhaTabuleiro(Linha))
        {
            Console.WriteLine($"\nVocê digitou 'Linha: {Linha}'. Insira uma linha de 0 a {LinhasTotal - 1}.\n");
            continue;
        }

        Console.Write("Coluna: ");
        
        
        Coluna = Convert.ToInt32(Console.ReadLine());

        if (!ValidarColunaTabuleiro(Coluna))
        {
            Console.WriteLine($"\nVocê digitou 'Coluna: {Coluna}'. Insira uma coluna de 0 a {LinhasTotal - 1}.\n");
            continue;
        }

        if (!ValidarPosicaoTabuleiro(Tabuleiro, Linha, Coluna))
        {
            Console.WriteLine($"\nA posição [{Linha},{Coluna}] já está sendo ocupada.\n");
            continue;
        }

        if (Simbolo == 'X')
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Red;

        Tabuleiro[Linha, Coluna] = Simbolo;
        Console.ResetColor();
        break;
    }

    return Tabuleiro;
}


bool VerificarVitoria(char[,] Tabuleiro)
{
    int ContadorDiagPrincipalX = 0, ContadorDiagPrincipalO = 0, ContadorDiagSecundariaX = 0, ContadorDiagSecundariaO = 0;

    for (int Linha = 0; Linha < LinhasTotal; Linha++)
    {
        int ContadorLinhaX = 0, ContadorLinhaO = 0;
        int ContadorColunaX = 0, ContadorColunaO = 0;

        for (int Coluna = 0; Coluna < ColunasTotal; Coluna++)
        {
            switch (Tabuleiro[Linha, Coluna])
            {
                case 'X': ContadorLinhaX++; break;
                case 'O': ContadorLinhaO++; break;
                default: break;
            }

            switch (Tabuleiro[Coluna, Linha])
            {
                case 'X': ContadorColunaX++; break;
                case 'O': ContadorColunaO++; break;
                default: break;
            }

            if(Linha == Coluna)
            {
                switch (Tabuleiro[Linha, Coluna])
                {
                    case 'X': ContadorDiagPrincipalX++; break;
                    case 'O': ContadorDiagPrincipalO++; break;
                    default: break;
                }
            }

            if(Linha == ((ColunasTotal - 1) - Coluna))
            {
                switch (Tabuleiro[Linha, Coluna])
                {
                    case 'X': ContadorDiagSecundariaX++; break;
                    case 'O': ContadorDiagSecundariaO++; break;
                    default: break;
                }
            }
        }

        if (ContadorLinhaX == LinhasTotal ||
               ContadorLinhaO == LinhasTotal ||
               ContadorColunaX == ColunasTotal ||
               ContadorColunaO == ColunasTotal ||
               ContadorDiagPrincipalX == LinhasTotal ||
               ContadorDiagPrincipalO == LinhasTotal ||
               ContadorDiagSecundariaX == LinhasTotal ||
               ContadorDiagSecundariaO == LinhasTotal)
        {
            JogoEncerrado = true;
            return true;
        }
           
    }

    return false;
}

bool VerificarEmpate(char[,] Tabuleiro)
{
    int PosicoesPreenchidas = 0;

    if(!VerificarVitoria(Tabuleiro))
        for(int Linha = 0;Linha < LinhasTotal; Linha++)
        {
            for(int Coluna = 0;Coluna < ColunasTotal; Coluna++)
            {
                if (Tabuleiro[Linha,Coluna] == 'X' || Tabuleiro[Linha,Coluna] == 'O')
                {
                    PosicoesPreenchidas++;
                }
            }
        }

    if (PosicoesPreenchidas == Tabuleiro.Length)
    {
        JogoEncerrado = true;
        return true;
    }
        

    return false;
}

char[,] LimparTabuleiro(char[,] Tabuleiro)
{
    for (int Linha = 0; Linha < LinhasTotal; Linha++)
    {
        for(int Coluna = 0; Coluna < ColunasTotal; Coluna++)
        {
            Tabuleiro[Linha, Coluna] = ' ';
        }
    }

    return Tabuleiro;
}


void ExibirHistorico(int ModoJogo) {

    Console.WriteLine("HISTÓRICO DE PARTIDAS");



}

void ExibirPlacar(int ModoJogo,int Vitorias, int Derrotas, int Empates)
{
    Console.WriteLine("PLACAR GERAL:");
    Console.WriteLine($"Jogador 1: {Vitorias} VITÓRIAS | {Derrotas} DERROTAS");

    if(ModoJogo == 1)
    Console.WriteLine($"Jogador 2: {Vitorias} VITÓRIAS | {Derrotas} DERROTAS");

    else if(ModoJogo == 2)
        Console.WriteLine($"Computador: {Vitorias} VITÓRIAS | {Derrotas} DERROTAS");

    Console.WriteLine($"EMPATES: {Empates}");


}


void JogoPVP(char[,] Tabuleiro, int VezJogador, char Simbolo, bool Recomecar)
{

    do { 
    int RecomecarOpcao = 0;
    ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);

    while (!JogoEncerrado)
    {
        Console.WriteLine($"JOGADOR {VezJogador} ({Simbolo}):");
        Tabuleiro = InserirSimbolo(Tabuleiro, Simbolo);

        if (VerificarVitoria(Tabuleiro))
        {
            ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nJogador {VezJogador} ({Simbolo}) venceu!");
            Console.ResetColor();

            if (Simbolo == 'X') VitoriasJogador1++;
            else VitoriasJogador2++;

            break;
        }
        else if (VerificarEmpate(Tabuleiro))
        {
            ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEmpate!");
            Console.ResetColor();
            EmpatesJogadores++;
            break;
        }


        Simbolo = (Simbolo == 'X') ? 'O' : 'X';
        VezJogador = (VezJogador == 1) ? 2 : 1;

        ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
    }

    if (JogoEncerrado)
    {
        Console.WriteLine("\nDeseja Recomeçar?\n1.Sim\n2.Encerrar Programa");
        RecomecarOpcao = Convert.ToInt32(Console.ReadLine());

        switch (RecomecarOpcao)
        {
            case 1: Recomecar = true; JogoEncerrado = false; Tabuleiro = LimparTabuleiro(Tabuleiro); Simbolo = 'X'; VezJogador = 1; Console.Clear(); break;
            case 2: Recomecar = false; Console.WriteLine("Saindo do jogo..."); break;
            default: Console.WriteLine("Digite 1 ou 2."); break;
        }
    }
} while (Recomecar) ;
}

void JogoPVC(char[,] Tabuleiro, char Simbolo, bool Recomecar)
{
    do
    {
        int RecomecarOpcao = 0;
        int LinhaComputador = 0, ColunaComputador = 0;
        ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);

        while (!JogoEncerrado)
        {
            Console.WriteLine($"JOGADOR ({Simbolo}):");
            Tabuleiro = InserirSimbolo(Tabuleiro, Simbolo);

            Simbolo = (Simbolo == 'X') ? 'O' : 'X';

            while (true)
            {
                LinhaComputador = Random.Shared.Next(0, 3);
                ColunaComputador = Random.Shared.Next(0, 3);

                if (ValidarPosicaoTabuleiro(Tabuleiro, LinhaComputador, ColunaComputador))
                {
                    Tabuleiro[LinhaComputador, ColunaComputador] = 'O';
                    break;
                }
            }

            Simbolo = (Simbolo == 'X') ? 'O' : 'X';

            if (VerificarVitoria(Tabuleiro))
            {
                ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nJogador ({Simbolo}) venceu!");
                Console.ResetColor();

                if (Simbolo == 'X') VitoriasPVC++;
                else DerrotasPVC++;

                break;
            }
            else if (VerificarEmpate(Tabuleiro))
            {
                ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nEmpate!");
                Console.ResetColor();
                EmpatesPVC++;
                break;
            }

            ExibirTabuleiro(Tabuleiro, LinhasTotal, ColunasTotal);
        }

        if (JogoEncerrado)
        {
            Console.WriteLine("\nDeseja Recomeçar?\n1.Sim\n2.Voltar ao Menu anterior");
            RecomecarOpcao = Convert.ToInt32(Console.ReadLine());

            switch (RecomecarOpcao)
            {
                case 1: Recomecar = true; JogoEncerrado = false; Tabuleiro = LimparTabuleiro(Tabuleiro); Simbolo = 'X'; Console.Clear(); break;
                case 2: Recomecar = false; Console.WriteLine("Saindo do jogo..."); break;
                default: Console.WriteLine("Digite 1 ou 2."); break;
            }
        }
    } while (Recomecar);
}

void JogoPrincipal(char[,] Tabuleiro)
{
    int ModoDeJogo = 0, OpcaoMenuPVP = 0, OpcaoMenuPVC = 0;
    bool Recomecar = false;
    char Simbolo = 'X';
    int VezJogador = 1;


    do
    {
        ExibirMenuPrincipal();
        ModoDeJogo = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        if (ModoDeJogo == 1)
        {
            do
            {
                ExibirMenuPVP();
                OpcaoMenuPVP = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (OpcaoMenuPVP)
                {
                    case 1:
                        JogoPVP(Tabuleiro, VezJogador, Simbolo, Recomecar);
                        break;
                    case 2:
                        ExibirHistorico(ModoDeJogo);
                        break;
                    case 3:
                        ExibirPlacar(ModoDeJogo,VitoriasJogador1,VitoriasJogador2,EmpatesJogadores);
                        break;
                    case 4:

                        break;
                    default:
                        break;
                }
            } while (OpcaoMenuPVP < 1 || OpcaoMenuPVP > 4);

        }
        else if(ModoDeJogo == 2)
        {
            do
            {
                ExibirMenuPVC();
                OpcaoMenuPVC = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (OpcaoMenuPVC)
                {
                    case 1:
                        JogoPVC(Tabuleiro, Simbolo, Recomecar);
                        break;
                    case 2:
                        ExibirHistorico(ModoDeJogo);
                        break;
                    case 3:
                        ExibirPlacar(ModoDeJogo,VitoriasPVC,DerrotasPVC,EmpatesPVC);
                        break;
                    case 4:

                        break;
                    default:
                        break;
                }
            } while (OpcaoMenuPVC < 1 || OpcaoMenuPVC > 4);
        }
        else
        {
            Console.WriteLine("Encerrando Programa...");
            break;
        }
    } while (ModoDeJogo < 1 || ModoDeJogo > 3);

}

JogoPrincipal(Tabuleiro);
