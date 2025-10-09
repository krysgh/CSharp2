// See https://aka.ms/new-console-template for more informatio

int Numero, Controle = 1;

while (Controle == 1){

    Console.WriteLine("Digite um número entre 1 e 10:");
    Numero = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine("\n");

    if (Numero >= 1 && Numero <= 10)
    {
        Console.WriteLine("TABUADA DO " + Numero);
        for (int I = 1; I <= 10; I++)
        {
            Console.WriteLine(Numero + " * " + I + " = " + (Numero * I));
        }

        Console.WriteLine("\n");
        Controle = 0;
    }
    else
    {
        Console.WriteLine("O número digitado está fora do intervalo (1-10).");
        Console.WriteLine("\n");
    }
}