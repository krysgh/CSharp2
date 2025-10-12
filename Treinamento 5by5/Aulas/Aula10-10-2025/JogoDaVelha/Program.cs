// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

const int linhasTotal = 3;
const int colunasTotal = 3;
int Encerrado = 0;

char[,] tabuleiro =
{
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' },
    { ' ', ' ', ' ' }
};

void ExibirTabuleiro(char[,] tabuleiro, int linhas, int colunas)
{
    Console.WriteLine("--------------------------------\nTABULEIRO ATUAL:\n");
    for (int referenciaLinha = 0; referenciaLinha < linhas; referenciaLinha++)
    {
        for (int referenciaColuna = 0; referenciaColuna < colunas; referenciaColuna++)
        {
            if(referenciaColuna != colunas - 1)
                Console.Write($" {tabuleiro[referenciaLinha, referenciaColuna]} |");
            else
                Console.Write($" {tabuleiro[referenciaLinha, referenciaColuna]}");
        }
        if (referenciaLinha != linhas - 1)
            Console.WriteLine("\n-----------");

    }
    Console.WriteLine("\n");
}

bool ValidarLinhaTabuleiro(int linha)
{
    return linha >= 0 && linha < 3 ;
}

bool ValidarColunaTabuleiro(int coluna)
{
    return coluna >= 0 && coluna < 3 ;
}

bool ValidarPosicaoTabuleiro(char[,] tabuleiro, int linha, int coluna)
{
    return tabuleiro[linha, coluna] == ' ';
}

void ImprimirVencedor(int numeroJogador, int contador)
{
    if(contador == 3)
    {
        Console.WriteLine($"Jogador {numeroJogador} venceu!");
        Encerrado++;
    }

}

void Resultado(char[,] tabuleiro)
{
    int contadorXDiagonal = 0, contadorODiagonal = 0;
    int contadorXDiagonalInversa = 0, contadorODiagonalInversa = 0;

    for (int linha = 0; linha < linhasTotal; linha++)
    {
        int contadorXLinha = 0, contadorOLinha = 0;
        int contadorXColuna = 0, contadorOColuna = 0;
        

        for (int coluna = 0; coluna < colunasTotal; coluna++)
        {

            if (tabuleiro[linha, coluna] == 'X')
            {
                contadorXLinha++;
                ImprimirVencedor(1, contadorXLinha);
            }

            if (tabuleiro[coluna, linha] == 'X')
            {
                contadorXColuna++;
                ImprimirVencedor(1,contadorXColuna);
            }

            if (linha == coluna && tabuleiro[linha, coluna] == 'X')
            {
                contadorXDiagonal++;
                ImprimirVencedor(1, contadorXDiagonal);
            }

            if (linha == ((colunasTotal - 1) - coluna) && tabuleiro[linha, coluna] == 'X')
            {
                contadorXDiagonalInversa++;
                ImprimirVencedor(1, contadorXDiagonalInversa);
            }

            if (tabuleiro[linha, coluna] == 'O')
            {
                contadorOLinha++;
                ImprimirVencedor(2,contadorOLinha);
            }

            if (tabuleiro[coluna, linha] == 'O')
            {
                contadorOColuna++;
                ImprimirVencedor(2, contadorOColuna);
            }

            if (linha == coluna && tabuleiro[linha, coluna] == 'O')
            {
                contadorODiagonal++;
                ImprimirVencedor(2, contadorODiagonal);
            }

            if (linha == ((colunasTotal - 1) - coluna) && tabuleiro[linha, coluna] == 'O')
            {
                contadorODiagonalInversa++;
                ImprimirVencedor(2, contadorODiagonalInversa);
            }
        }
    }
}   

char[,] Jogo(char[,] tabuleiro)
{

    int linhaEscolhida, colunaEscolhida, vezJogador = 1;
    char simbolo = 'X';

    while (Encerrado == 0)
    {

        Console.WriteLine($"JOGADOR {vezJogador} ({simbolo}):");
        Console.WriteLine("Insira a posição a ser jogada.");
        Console.Write("Linha: ");
        linhaEscolhida = int.Parse(Console.ReadLine()!);

        Console.Write("Coluna: ");
        colunaEscolhida = int.Parse(Console.ReadLine()!);

        if (ValidarLinhaTabuleiro(linhaEscolhida))
        {
            if (ValidarColunaTabuleiro(colunaEscolhida))
            {
                if (ValidarPosicaoTabuleiro(tabuleiro, linhaEscolhida, colunaEscolhida))
                {
                    tabuleiro[linhaEscolhida, colunaEscolhida] = Convert.ToChar(simbolo);

                    if (vezJogador == 1)
                        vezJogador = 2;
                    else
                        vezJogador = 1;

                    if (simbolo == 'X')
                        simbolo = 'O';
                    else
                        simbolo = 'X';

                }
                else
                {
                    Console.Write($"Erro! A posição [{linhaEscolhida},{colunaEscolhida}] já está sendo ocupada.");
                }
            }
            else
            {
                Console.Write($"Erro! Você digitou 'Coluna: {colunaEscolhida}'\nInsira uma coluna entre 0 e 2.");
            }
        }
        else
        {
            Console.Write($"Erro! Você digitou 'Linha: {linhaEscolhida}'\nInsira uma linha entre 0 e 2.");
        }

        Console.WriteLine("\n");

        Resultado(tabuleiro);

        

            ExibirTabuleiro(tabuleiro, linhasTotal, colunasTotal);
    }

    return tabuleiro;
    
}

ExibirTabuleiro(tabuleiro, linhasTotal, colunasTotal);
Jogo(tabuleiro);
Resultado(tabuleiro);