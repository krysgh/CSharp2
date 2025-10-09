// See https://aka.ms/new-console-template for more information

int N;

Console.WriteLine("Digite um número inteiro N:");
N = int.Parse(Console.ReadLine()??string.Empty);

Console.WriteLine("\nNÚMEROS PARES ATÉ " + N);

for (int I = 1; I <= N; I++)
{ 
    if(I % 2 == 0)
        Console.WriteLine(I); 
    
}

