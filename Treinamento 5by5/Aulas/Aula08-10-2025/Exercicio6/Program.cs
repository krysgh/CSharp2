// See https://aka.ms/new-console-template for more information

int[] Numeros = new int[10];
int Pares = 0, Impares = 0;

for (int I = 0; I < 10; I++)
{ 
    Console.WriteLine("Digite um número inteiro para a posição " + I + " do vetor:");
    Numeros[I] = int.Parse(Console.ReadLine()??string.Empty);

    Console.WriteLine("\n");

    if (Numeros[I] % 2 == 0)
        Pares++;
    else
    {
        Impares++;
    }       
}

Console.WriteLine("Quantidade de Pares: " + Pares);
Console.WriteLine("Quantidade de Ímpares: " + Impares);