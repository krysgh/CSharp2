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

        public bool Vazia()
        {
            return this.Head == null;
        }

        public void Enfileirar(Cliente c)
        {
            if (Vazia())
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                this.Tail.SetProximo(c);
                this.Tail = c;
            }
        }

        public void Desenfileirar()
        {

            if (Vazia())
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

        public void MostrarFila()
        {
            if (Vazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Cliente aux = this.Head;
                while (aux != null)
                {
                    Console.Write($"{aux.GetNome()} -> ");
                        aux = aux.GetProximo();
                }
            }
        }

    }
}
