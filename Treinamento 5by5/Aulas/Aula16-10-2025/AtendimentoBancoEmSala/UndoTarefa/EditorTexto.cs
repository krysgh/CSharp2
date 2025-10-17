using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoTarefa
{
    public class EditorTexto
    {
        public Pilha historico {  get; set; }
        
        public EditorTexto()
        {
            this.historico = new Pilha();
        }

        public void Digitar(string texto)
        {
            this.historico.Empilhar(texto);
        }

        public void Desfazer()
        {
            this.historico.Desempilhar();
        }

        public void MostrarHistorico()
        {
            Console.WriteLine("HISTÓRICO DE 'CTRL + Z':\n");
            this.historico.ExibirPilha();
        }

    }
}
