// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Xml;

int linhas, colunas;

int[,] ConstruirMatriz(int linhas, int colunas) 
{ 
    return new int[linhas, colunas];
}

int[,] PopularMatriz(int[,] matriz, int linhas, int colunas)
{
    for(int referenciaLinha = 0;referenciaLinha < linhas; referenciaLinha++)
    {
        for (int referenciaColuna = 0; referenciaColuna < colunas; referenciaColuna++)
        {
            matriz[referenciaLinha, referenciaColuna] = Random.Shared.Next(1, 50);
        }
    }
       
    return matriz;
}

void ImprimirMatriz(int[,] matriz, int linhas, int colunas)
{
    Console.WriteLine("\nMATRIZ: ");

    for (int referenciaLinha = 0; referenciaLinha < linhas; referenciaLinha++)
    {
        for (int referenciaColuna = 0; referenciaColuna < colunas; referenciaColuna++)
        {
            Console.Write("[ " + matriz[referenciaLinha, referenciaColuna] + " ] ");
        }
        Console.WriteLine();
    }
     
}




Console.WriteLine("Informe a quantidade de linhas desejadas: ");
linhas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe a quantidade de colunas desejadas: ");
colunas = int.Parse(Console.ReadLine()!);

var matriz = ConstruirMatriz(linhas, colunas);

matriz = PopularMatriz(matriz, linhas, colunas);

ImprimirMatriz(matriz, linhas, colunas);


/*
int[,] matriz = new int[3,3];


Console.WriteLine("MATRIZ: ");
for(int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
        matriz[linha, coluna] = Random.Shared.Next(1, 100);

        Console.Write($"[ {matriz[linha, coluna]} ] ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nMATRIZ INVERSA: ");

for (int linha = 2; linha >= 0; linha--)
{
    for (int coluna = 2; coluna >= 0; coluna--)
        Console.Write($"[ {matriz[linha, coluna]} ] ");
    
    Console.WriteLine();
}
*/
