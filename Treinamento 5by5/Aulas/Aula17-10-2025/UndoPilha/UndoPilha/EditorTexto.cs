using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoPilha
{
    public class EditorTexto
    {
        public Pilha historico { get; set; }

        public Pilha CtrlZPrincipal { get; set; }

        public EditorTexto()
        {
            this.historico = new Pilha();
            this.CtrlZPrincipal = new Pilha(0);
        }

        public void Digitar(NoCtrlZ texto)
        {
            this.CtrlZPrincipal.Empilhar(texto);
            this.historico.Empilhar(texto);
        }

        public void Desfazer()
        {   if (this.CtrlZPrincipal.EstaVazia())
                Console.WriteLine("Pilha Vazia");
            else
                this.CtrlZPrincipal.Desempilhar();
        }

        public void MostrarHistorico()
        {
            Console.WriteLine("HISTÓRICO DE 'CTRL + Z':\n");
            this.historico.ExibirPilha();
        }

        public void MostrarPilha()
        {
            Console.WriteLine("ÚLTIMOS 'CTRL + Z':\n");
            this.CtrlZPrincipal.ExibirPilha();
        }

    }
}
