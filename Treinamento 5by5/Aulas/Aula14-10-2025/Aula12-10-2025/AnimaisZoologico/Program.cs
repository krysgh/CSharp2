// See https://aka.ms/new-console-template for more information

using AnimaisZoologico;


void CadastrarNomeIdade(Animal[] Animais, int indice)
{
    Console.WriteLine($"CADASTRO DO ANIMAL {indice + 1}");

    Console.Write("Informe o nome do animal: ");
    Animais[indice].SetNome(Console.ReadLine()!);

    Console.Write("Informe a idade do animal: ");
    Animais[indice].SetIdade(Convert.ToInt32(Console.ReadLine()));

}

Console.WriteLine("Quantos animais deseja inserir no zoológico?");
int qtdAnimais = Convert.ToInt32(Console.ReadLine());

Animal[] Animais = new Animal[qtdAnimais];
Console.Clear();

for(int i = 0; i < qtdAnimais; i++)
{
    int opcao;
    do
    {
        Console.WriteLine($"Qual é o {i + 1}º animal?");
        Console.WriteLine("1-Cachorro");
        Console.WriteLine("2-Gato");
        Console.WriteLine("3-Leão");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
            case 1: Animais[i] = new Cachorro(); CadastrarNomeIdade(Animais, i); Console.Clear(); break;
            case 2: Animais[i] = new Gato(); CadastrarNomeIdade(Animais, i); Console.Clear(); break;
            case 3: Animais[i] = new Leao(); CadastrarNomeIdade(Animais, i); Console.Clear(); break;
            default: Console.WriteLine("Digite 1, 2 ou 3"); break;
        }

    }while(opcao < 1 || opcao > 3);
    
}


Console.WriteLine("---------------------\nANIMAIS NO ZOOLÓGICO\n");
for(int i = 0;i < qtdAnimais; i++)
{
    Console.WriteLine($"Animal {i + 1}");
    Console.WriteLine(Animais[i].ToString());
    Console.Write($"Som: ");
    Animais[i].EmitirSom();
    Console.WriteLine();
}
Console.WriteLine("---------------------");