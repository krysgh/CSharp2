// See https://aka.ms/new-console-template for more information

int[] numeros = new int[5];
int soma = 0;
double media = 0.0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número inteiro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    soma += numeros[i];
    media = soma / Convert.ToDouble(numeros.Length);
    Console.WriteLine();
}

Console.WriteLine("SOMA: " + soma);

Console.WriteLine("MÉDIA: " + media);

