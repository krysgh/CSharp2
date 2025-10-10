// See https://aka.ms/new-console-template for more information

const int linhas = 3;
const int colunas = 3;

string[,] tabuleiro =
{
    { " ", " ", " " },
    { " ", " ", " " },
    { " ", " ", " " }
};

void ExibirTabuleiro(string[,] tabuleiro, int linhas, int colunas)
{
    for (int referenciaLinha = 0; referenciaLinha < linhas; referenciaLinha++)
    {
        for (int referenciaColuna = 0; referenciaColuna < colunas; referenciaColuna++)
        {
            if(referenciaColuna != colunas - 1)
                Console.Write($"{tabuleiro[referenciaLinha, referenciaColuna]} |");
            else
                Console.Write($"{tabuleiro[referenciaLinha, referenciaColuna]}");
        }
        if(referenciaLinha != linhas -1)
            Console.WriteLine("\n--------");
    }
}

ExibirTabuleiro(tabuleiro, linhas, colunas);
