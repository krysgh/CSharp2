using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRoupa
{
    public class Pilha
    {
        public Roupa Top { get; set; }


        public Pilha()
        {
            this.Top = null;
        }


        public bool Void()
        {
            return this.Top == null;
        } 

        public void Push(Roupa top)
        {
            if(Void())
                this.Top = top;
            else
            {
                Roupa aux = this.Top;
                this.Top = top;
                this.Top.Proximo = aux;
            }
        }

        public Roupa Pop()
        {
            if (Void())
                return null;
            else
            {
                Roupa aux = this.Top;
                this.Top = this.Top.Proximo;

                return aux;
            }
        }


        public void showStack()
        {
            if (Void())
                Console.WriteLine("Pilha está vazia");
            else
            {
                Roupa aux = this.Top;

                while(aux != null)
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;

                }
            }
                

                
        }

    }
}
