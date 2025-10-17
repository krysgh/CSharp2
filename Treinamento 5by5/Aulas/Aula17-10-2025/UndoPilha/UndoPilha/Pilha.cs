using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoPilha
{
    public class Pilha
    {

        public NoCtrlZ Top { get; set; }

        public int Contador {  get; set; }

        public Pilha(int inicio)
        {
            this.Contador = inicio;
            
        }

        public Pilha()
        {
            this.Top = null;
        }

        public bool EstaVazia()
        {
            return this.Top == null;
        }

        public bool EstaCheia()
        {
            return this.Contador > 9;
        }

        public void Empilhar(NoCtrlZ item)
        {
            if (EstaCheia())
            {
                Console.WriteLine("Pilha Cheia\n");
            }
            else if (EstaVazia())
            {
                this.Contador++;
                this.Top = item;
            }
            else
            {
                this.Contador++;
                NoCtrlZ aux = this.Top;
                this.Top = item;
                this.Top.Proximo = aux;
                
            }
        }

        public NoCtrlZ Desempilhar()
        {
            if (EstaVazia())
            {
                Console.WriteLine("Pilha está vazia!");
                return null;
            }
            else
            {
                this.Contador--;
                NoCtrlZ aux = this.Top;
                this.Top = this.Top.Proximo;
                return aux;
            }

        }

        public NoCtrlZ Topo()
        {
            if (EstaVazia())
            {
                return null;
            }
            return this.Top;
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
            {
                Console.WriteLine("VAZIO");
            }
            else
            {
                NoCtrlZ aux = this.Top;

                while(aux != null)
                {
                    Console.WriteLine(aux);
                    aux = aux.Proximo;
                }
            }
        }

    }
}
