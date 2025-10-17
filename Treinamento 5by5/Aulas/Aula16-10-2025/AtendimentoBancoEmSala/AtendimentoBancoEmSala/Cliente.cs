using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoBancoEmSala
{
    public class Cliente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public bool EhPrioritario { get; set; }

        public Cliente Proximo { get; set; }

        public Cliente(string nome, int idae)
        {
            Nome = nome;
            Idade = idae;
            this.Proximo = null;
            if (this.Idade > 59)
                EhPrioritario = true;
            else
                EhPrioritario = false;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Idade : {this.Idade}\n" +
                $"Prioritário: " + (this.EhPrioritario ? "Sim" : "Não");
        }
    }
}
