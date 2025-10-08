// See https://aka.ms/new-console-template for more information

int N, Controle = 1, Fibonacci = 0, Auxiliar = 0, Auxiliar1 = 1;


while (Controle == 1)
{

    Console.WriteLine("Digite um número inteiro positivo para N: ");
    N = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine("\n");

    if (N >= 1)
    {
        for (int I = 0; I < N; I++)
        {
            Console.WriteLine(Fibonacci);
            Auxiliar = Auxiliar1;
            Auxiliar1 = Fibonacci;
            Fibonacci = Auxiliar + Auxiliar1;
        }

        Console.WriteLine("\n");
        Controle = 0;
    }
    else
    {
        Console.WriteLine("O número não pode ser menor que 1.");
        Console.WriteLine("\n");
    }
}
