
// See https://aka.ms/new-console-template for more information

int Numero, Fatorial = 0;

do
{
    Console.WriteLine("Digite um número inteiro positivo para calcular seu fatorial: ");
    Numero = int.Parse(Console.ReadLine()!);

    Console.WriteLine("\n");

    if (Numero >= 1)
    {
        for (int I = Numero; I >= 1; I--)
        {
            if (I == Numero)
                Fatorial = I;
            else
                Fatorial *= I;
        }

        Console.WriteLine("O fatorial de " + Numero + " = " + Fatorial);

    }
    else
    {
        Console.WriteLine("Insira um número maior ou igual a 1.");

        Console.WriteLine("\n");

    }

        

} while (Numero < 1);