// See https://aka.ms/new-console-template for more information

using GerenciamentoFuncionarios;


Funcionario[] VetorFuncionario;

void InserirNomeESalarioBase(Funcionario[] vetorFuncionario, int indiceVetor)
{
    Console.WriteLine($"Digite o nome do funcionário {indiceVetor + 1}: ");
    vetorFuncionario[indiceVetor].SetNome(Console.ReadLine()!);

    Console.WriteLine($"Digite o salário base do funcionário {indiceVetor + 1}: ");
    vetorFuncionario[indiceVetor].SetSalarioBase(Convert.ToDouble(Console.ReadLine()!));

}


Console.WriteLine("Informe o número de funcionários que deseja cadastrar:");
int qtdFuncionarios = Convert.ToInt32(Console.ReadLine());
VetorFuncionario = new Funcionario[qtdFuncionarios];

Console.Clear();

for (int i = 0; i < qtdFuncionarios; i++)
{
    int opcao;

    do
    { 
        Console.WriteLine("Deseja Cadastrar:\n1-CLT\n2-PJ?");
        opcao = Convert.ToInt32(Console.ReadLine());

        Console.Clear();


        if (opcao == 1)
        {
            VetorFuncionario[i] = new FuncionarioCLT();

            InserirNomeESalarioBase(VetorFuncionario, i);

            Console.WriteLine($"Digite o bônus do funcionário {i + 1}: ");
            ((FuncionarioCLT)VetorFuncionario[i]).SetBonus(Convert.ToDouble(Console.ReadLine()!));
            Console.Clear();


        }

        else if (opcao == 2)
        {
            VetorFuncionario[i] = new FuncionarioPJ();

            InserirNomeESalarioBase(VetorFuncionario, i);

            Console.WriteLine($"Digite a quantidade de horas trabalhadas do funcionário {i + 1}: ");
            ((FuncionarioPJ)VetorFuncionario[i]).SetHorasTrabalhadas(Convert.ToInt32(Console.ReadLine()!));

            Console.WriteLine($"Digite o valor por hora do funcionário {i + 1}: ");
            ((FuncionarioPJ)VetorFuncionario[i]).SetValorHora(Convert.ToDouble(Console.ReadLine()!));
            Console.Clear();

        }

        else
            Console.WriteLine("Digite 1 ou 2.\n\n");

    } while (opcao < 1 || opcao > 2);
}

Console.WriteLine("-----------------------\nFUNCIONÁRIOS CADASTRADOS\n");

for (int i = 0;i < qtdFuncionarios; i++)
{
    VetorFuncionario[i].ExibirInfo();
    Console.WriteLine("-----------------------");
}


