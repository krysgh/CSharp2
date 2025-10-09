// See https://aka.ms/new-console-template for more information

String Menu = "Digite uma opção:\n1-Soma\n2-Subtração\n3-Multiplicação\n4-Sair";
int Controle = 1, Operacao, Numero1, Numero2;

while (Controle == 1)
{
    Console.WriteLine(Menu);
    Operacao = int.Parse(Console.ReadLine()??string.Empty);

    Console.WriteLine("\n");

    if (Operacao >= 1 && Operacao <=4)
    {
        if (Operacao == 4)
        {
            Console.WriteLine("Saindo do Programa...");
            break;
        }

        Console.WriteLine("Digite um número inteiro: ");
        Numero1 = int.Parse(Console.ReadLine() ?? string.Empty);


        Console.WriteLine("Digite outro número inteiro: ");
        Numero2 = int.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("\n");

        switch (Operacao)
        {
            case 1:
                int Soma = Numero1 + Numero2;
                Console.WriteLine("SOMA");
                Console.WriteLine(Numero1 + " + " + Numero2 + " = " + Soma);
                Console.WriteLine("\n");
                break;
            case 2:
                Console.WriteLine("DIFERENÇA");
                int Diferenca = Numero1 - Numero2;
                Console.WriteLine(Numero1 + " - " + Numero2 + " = " + Diferenca);
                Console.WriteLine("\n");
                break;
            case 3:
                Console.WriteLine("MULTIPLICAÇÃO");
                Console.WriteLine(Numero1 + " * " + Numero2 + " = " + (Numero1 * Numero2));
                Console.WriteLine("\n");
                break;
        }
    }
    else
    {
        Console.WriteLine("A opção digitada está fora do intervalo (1-4)");
    }
}
