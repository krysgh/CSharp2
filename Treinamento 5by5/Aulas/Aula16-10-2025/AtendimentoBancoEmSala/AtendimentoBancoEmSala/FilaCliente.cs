using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBancoEmSala
{
    public class FilaCliente
    {
        private Cliente Head { get; set; }

        private Cliente Tail { get; set; }

        public FilaCliente()
        {
            Head = null;
            Tail = null;
        }
        
        public bool Vazia()
        {
            return this.Head == null;
        }


        public void Enfileirar(Cliente c)
        {
            if(Vazia())
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                this.Tail.Proximo = c;
                this.Tail = c;
            }
        }

        public Cliente Desenfileirar()
        {
            if (Vazia())
            {
                return null;
            }
            else
            {
                Cliente aux = this.Head;
                this.Head = this.Head.Proximo;
                if(this.Head == null)
                {
                    this.Tail = null;
                }
                return aux;
            }
        }


        public void MostrarFila(){
            if(Vazia())
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Cliente aux = this.Head;
                while(aux != null)
                {
                    Console.WriteLine(aux.ToString());
                }
            }
        }

    }
}
