using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoTarefa
{
    public class Pilha
    {
        public string[] CtrlZ {  get; set; }

        public int Top {  get; set; }

        public Pilha()
        {
            this.Top = -1;
            this.CtrlZ = new string[10];
        }

        public bool EstaVazia()
        {
            return this.Top == -1;
        }

        public bool EstaCheia()
        {
            return this.Top == 9;
        }

        public void Empilhar(string item )
        {
            if (EstaCheia())
            {
                Console.WriteLine("Pilha Cheia\n");
            }
            else
            {
                this.Top++;
                this.CtrlZ[this.Top] = item;
            } 
        }

        public string Desempilhar()
        {
            if (EstaVazia())
            {
                return "";
            }
            else
            {
                string aux = this.CtrlZ[this.Top];
                this.CtrlZ[this.Top] = "";
                this.Top--;

                return aux;
            }
            
        }

        public string Topo()
        {
            if (EstaVazia())
            {
                return "";
            }
            return this.CtrlZ[this.Top];
        }

        public void ExibirPilha()
        {
            if (EstaVazia())
            {
                Console.WriteLine("HISTÓRICO VAZIO");
            }
            else
            {
                for (int i = this.Top; i >= 0; i--)
                {
                    Console.WriteLine($"{this.CtrlZ[i]}");
                }
            }
        }
    }
}
