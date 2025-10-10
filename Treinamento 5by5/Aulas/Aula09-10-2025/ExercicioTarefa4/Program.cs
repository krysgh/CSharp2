// See https://aka.ms/new-console-template for more information

int[] numeros = new int[10];
int numBusca, ocorrencia = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

Console.WriteLine("Digite um número inteiro para ser buscado no vetor: ");
numBusca = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write($"OCORRÊNCIAS DE {numBusca}: ");

for(int i = 0;i < numeros.Length; i++)
{
    if (numeros[i] == numBusca)
        ocorrencia++;
}

Console.Write(ocorrencia + "x.");
Console.WriteLine();