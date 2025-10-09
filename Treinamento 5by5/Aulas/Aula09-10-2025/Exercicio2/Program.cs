// See https://aka.ms/new-console-template for more information

bool EhPar(int Numero) 
{
    return Numero % 2 == 0;
}

int Numero;

Console.WriteLine("Digite um número inteiro: ");
Numero = int.Parse(Console.ReadLine()!);

Console.WriteLine();

if (EhPar(Numero))
    Console.WriteLine(Numero + " é par? -> SIM");
else
    Console.WriteLine(Numero + " é par? -> NÃO");