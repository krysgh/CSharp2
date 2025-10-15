using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjFilaDinamica
{
    public class Pessoa
    {

        public string Nome { get; set;}

        public Pessoa Proximo { get; set;}

        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.Proximo = null;
        }


    }
}
