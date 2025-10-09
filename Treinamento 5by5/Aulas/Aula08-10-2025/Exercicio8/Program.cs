// See https://aka.ms/new-console-template for more information

Random Rand = new Random();

int Numero = Rand.Next(1, 51);
int Tentativa;

Console.WriteLine("Tente acertar o número aleatório entre 1 e 50. ");

do
{
    Console.WriteLine("Insira um número inteiro: ");
    Tentativa = int.Parse(Console.ReadLine()!);

    if (Tentativa == Numero)
        Console.WriteLine("ACERTOU");
    else if (Tentativa > Numero)
        Console.WriteLine("O número é menor que " + Tentativa);
    else
        Console.WriteLine("O número é maior que " + Tentativa);

    Console.WriteLine("\n");

} while (Tentativa != Numero);

