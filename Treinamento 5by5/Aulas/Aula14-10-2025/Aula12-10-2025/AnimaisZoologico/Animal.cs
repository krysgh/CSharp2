using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisZoologico
{
    public abstract class Animal
    {
        private string Nome;
        private int Idade;

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }


        public abstract void EmitirSom();

        public string ToString()
        {
            return $"Nome: {this.Nome}\nIdade: {this.Idade}";
        }
    }
}
