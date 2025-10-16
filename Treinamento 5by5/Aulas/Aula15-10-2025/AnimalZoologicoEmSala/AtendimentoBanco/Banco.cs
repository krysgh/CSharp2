using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBanco
{
    public class Banco
    {
        private Fila FilaNormal { get; set; }

        private Fila FilaPrioritaria { get; set; }

        private int ContadorClienteNormal { get; set; }


        public Banco()
        {
            this.FilaNormal = new Fila();
            this.FilaPrioritaria = new Fila();
            this.ContadorClienteNormal = 0;
        }


        public void AtenderCliente()
        {
            if (this.ContadorClienteNormal < 2 || FilaPrioritaria.Vazia())
            {
                FilaNormal.Desenfileirar();
                this.ContadorClienteNormal++;
            }
            else if (FilaNormal.Vazia())
            {
                FilaPrioritaria.Desenfileirar();
            }
            else
            {
                FilaPrioritaria.Desenfileirar();
                this.ContadorClienteNormal = 0;
            }

        }

        public void Main()
        {
            int opcaoMenu, tipoCliente;

            do
            {
                do
                {
                    Console.Write("1 - Adicionar cliente\n2 - Atender próximo cliente\n3 - Mostrar filas\n0 - Sair\n\nDigite a opção desejada: ");
                    opcaoMenu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (opcaoMenu)
                    {
                        case 0:
                            Console.WriteLine("Saindo do programa...");
                            break;
                        case 1:
                            do
                            {
                                Console.Write("ADICIONAR CLIENTE\n\n1 - Comum\n2 - Prioritário\n\nDigite a opção desejada: ");
                                tipoCliente = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                if (tipoCliente == 1)
                                {
                                    Console.Write("Digite o nome do cliente: ");
                                    string nome = Console.ReadLine()!;
                                    Console.Write("Digite a idade do cliente: ");
                                    int idade = Convert.ToInt32(Console.ReadLine());

                                    FilaNormal.Enfileirar(new Cliente(nome,idade,false));
                                    Console.Clear();

                                }
                                else if (tipoCliente == 2)
                                {
                                    Console.Write("Digite o nome do cliente: ");
                                    string nome = Console.ReadLine()!;
                                    Console.Write("Digite a idade do cliente: ");
                                    int idade = Convert.ToInt32(Console.ReadLine());

                                    FilaPrioritaria.Enfileirar(new Cliente(nome, idade, true));
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Insira uma opção válida!");
                                }
                            } while (tipoCliente < 1 || tipoCliente > 2);

                            break;
                        case 2:
                            AtenderCliente();
                            Console.WriteLine("Cliente atendido com sucesso!");
                            break;
                        case 3:
                            Console.WriteLine("FILA COMMUM");
                            FilaNormal.MostrarFila();
                            Console.WriteLine("\n");

                            Console.WriteLine("FILA PRIORITÁRIA");
                            FilaPrioritaria.MostrarFila();
                            Console.WriteLine("\n----------------------------\n");
                            break;
                        default:
                            Console.WriteLine("Insira uma opção válida!");
                            break;
                    }
                } while (opcaoMenu < 0 || opcaoMenu > 3);
            } while (opcaoMenu != 0);
        }
    }
}
