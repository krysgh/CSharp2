// See https://aka.ms/new-console-template for more information

using SistemaVeiculos;

void InserirMarcaModeloAno(Veiculo[] veiculos, int indice)
{
    Console.Write($"Digite a marca do veículo {indice + 1}:");
    veiculos[indice].SetMarca(Console.ReadLine()!);
    Console.WriteLine();

    Console.Write($"Digite o modelo do veículo {indice + 1}:");
    veiculos[indice].SetModelo(Console.ReadLine()!);
    Console.WriteLine();

    Console.Write($"Digite o ano do veículo {indice + 1}:");
    veiculos[indice].SetAno(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine();

}


Console.WriteLine("Insira o número de veículos que deseja:");
int qtdVeiculos = Convert.ToInt32(Console.ReadLine());

Veiculo[] Veiculos = new Veiculo[qtdVeiculos];
Console.Clear();

for(int i = 0; i < qtdVeiculos; i++)
{

    int opcao;

    do
    {
        Console.WriteLine("Insira o veículo desejado:\n1-Carro\n2-Moto\n3-Caminhão");
        opcao = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
            case 1:
                Veiculos[i] = new Carro();
                InserirMarcaModeloAno(Veiculos, i);

                Console.Write($"Digite o número de portas do veículo {i + 1}:");
                ((Carro)Veiculos[i]).SetNumeroDePortas(Convert.ToInt32(Console.ReadLine()));

                Console.Clear();
                break;
            case 2:
                Veiculos[i] = new Moto();
                InserirMarcaModeloAno(Veiculos, i);

                int opcaoCapacete;

                do
                {
                    Console.WriteLine($"Capacete do veículo {i + 1} é obrigatório?\n0-Não\n2-Sim");
                    opcaoCapacete = Convert.ToInt32(Console.ReadLine());

                } while (opcaoCapacete < 0 || opcaoCapacete > 1);

                ((Moto)Veiculos[i]).SetCapaceteObrigatorio(Convert.ToBoolean(opcaoCapacete));

                Console.Clear();
                break;
            case 3:
                Veiculos[i] = new Caminhao();
                InserirMarcaModeloAno(Veiculos, i);

                Console.Write($"Digite a capacidade de carga do veículo {i + 1} em kg:");
                ((Caminhao)Veiculos[i]).SetCapacidadeDeCarga(Convert.ToDouble(Console.ReadLine()));
                break;
            default:
                Console.WriteLine("Digite 1, 2 ou 3.");
                break;

        }
    } while (opcao < 1 || opcao > 3);

}

Console.Clear();

Console.WriteLine("VEÍCULOS DIGITADOS\n");

for(int i = 0;i < qtdVeiculos; i++)
{
    Console.WriteLine($"Veiculo {i + 1}");
    Veiculos[i].ExibirInformacoes();
    Console.WriteLine();
}