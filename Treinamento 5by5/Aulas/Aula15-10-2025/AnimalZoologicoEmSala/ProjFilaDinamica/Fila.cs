using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaDinamica
{
    public class Fila
    {
        public Pessoa Head { get; set; }

        public Pessoa Tail { get; set; }

        public Fila()
        {
            this.Head = null;
            this.Tail = this.Head;
        }

        public bool FilaVazia(Pessoa h)
        {
            return h == null;
        }

        public void InserirPessoa(Pessoa elemento, Pessoa h, Pessoa t)
        {
            if (FilaVazia(h))
            {
                this.Head = elemento;
                this.Tail = elemento;
            }
            else
            {
                this.Tail.Proximo = elemento;
                this.Tail = elemento;
            }
        }

        public void RemoverPessoa(Pessoa h, Pessoa t)
        {

            if (FilaVazia(h))
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                this.Head = this.Head.Proximo;
                if (h == null)
                    this.Tail = null;
            }
        }

        public int TamanhoFila(Pessoa h)
        {
            int contador = 0;

            if (FilaVazia(h))
                return contador;
            else
            {
                Pessoa aux = h;

                do
                {
                    contador++;
                    aux = aux.Proximo;
                } while (aux != null);
            }

            return contador;
        }

        public void ImprimirFila(Pessoa h)
        {
            if (FilaVazia(h))
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Pessoa aux = h;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }



    }
}
