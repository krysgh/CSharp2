using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaRoupa
{
    public class Roupa
    {
        public string Nome {  get; set; }

        public string Descricao { get; set; }

        public Roupa Proximo { get; set; }

        public Roupa(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Proximo = null;
        }

        public override string ToString()
        {
            return $"Nome: {this.Nome}\nDescrição: {this.Descricao}";
        }


    }
}
