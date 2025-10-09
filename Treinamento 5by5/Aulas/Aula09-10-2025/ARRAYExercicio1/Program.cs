// See https://aka.ms/new-console-template for more information

int i = 0, tamanho = 0;

Console.WriteLine("Digite o tamanho do Array: ");
tamanho = Convert.ToInt32(Console.ReadLine());

int[] numeros = new int[tamanho];


for(i = 0; i < numeros.Length; i++)
{
    numeros[i] = Random.Shared.Next(0, 100);
}

Console.Write("\nVETOR: ");

for(i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i] + " ");
}


Console.Write("\n\nPRIMEIRA METADE DO VETOR: ");

for (i = 0;i < numeros.Length/ 2; i++)
{ 
    Console.Write(numeros[i] + " ");
}

Console.Write("\n\nSEGUNDA METADE DO VETOR NA ORDEM INVERSA: ");

for(i = numeros.Length - 1; i >= numeros.Length / 2; i--)
{
    Console.Write(numeros[i] + " ");
}

Console.WriteLine();