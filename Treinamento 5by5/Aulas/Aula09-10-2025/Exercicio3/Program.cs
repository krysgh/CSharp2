// See https://aka.ms/new-console-template for more information

int CalcularIdade(int AnoNascimento)
{
    return DateTime.Now.Year - AnoNascimento;
}

int AnoNascimento;

Console.WriteLine("Digite o ano do seu nascimento: ");
AnoNascimento = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Sua idade é " + CalcularIdade(AnoNascimento) + "."); 