using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBanco
{
    internal class Fila
    {

        public Cliente Head { get; set; }

        public Cliente Tail { get; set; }

        public Fila()
        {
            this.Head = null;
            this.Tail = this.Head;
        }

        public bool FilaVazia()
        {
            return this.Head == null;
        }

        public void InserirPessoa(Cliente elemento)
        {
            if (FilaVazia())
            {
                this.Head = elemento;
                this.Tail = elemento;
            }
            else
            {
                this.Tail.SetProximo(elemento);
                this.Tail = elemento;
            }
        }

        public void RemoverPessoa()
        {

            if (FilaVazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                this.Head = this.Head.GetProximo();
                if (this.Head == null)
                    this.Tail = null;
            }
        }

        public void ImprimirFila()
        {
            if (FilaVazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Cliente aux = this.Head;
                while (aux != null)
                {
                    Console.WriteLine(aux.GetNome());
                    aux = aux.GetProximo();
                }
            }
        }

    }
}
