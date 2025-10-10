// See https://aka.ms/new-console-template for more information

int[] numeros = new int[6];
int pares = 0, impares = 0;

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

    if (numeros[i] != 0)
    {
        if (numeros[i] % 2 == 0)
            pares++;
        else
            impares++;
    }

    Console.WriteLine();
}

int[] vetorPar = new int[pares];
int[] vetorImpar = new int[impares];
pares = 0; impares = 0;

Console.Write("VETOR: [ ");

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] != 0)
    {
        if (numeros[i] % 2 == 0)
            vetorPar[pares++] = numeros[i];
        else
            vetorImpar[impares++] = numeros[i];
    }

    Console.Write(numeros[i] + " ");

}

Console.WriteLine("]");

Console.Write("\nVETOR PAR: [ ");

for (int i = 0; i < vetorPar.Length; i++)
{
    Console.Write(vetorPar[i] + " ");
}

Console.WriteLine("]");

Console.Write("\nVETOR ÍMPAR: [ ");

for (int i = 0; i < vetorImpar.Length; i++)
{
    Console.Write(vetorImpar[i] + " ");
}

Console.WriteLine("]");

