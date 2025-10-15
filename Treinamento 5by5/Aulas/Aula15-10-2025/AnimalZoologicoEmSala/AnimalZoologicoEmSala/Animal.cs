using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoologicoEmSala
{
    public abstract class Animal
    {
        private string Nome {  get; set; }

        private int Idade { get; set;}


        public Animal(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }


        public string GetNome()
        {
            return this.Nome;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public abstract string EmitirSom();



        public override string ToString()
        {
            return $"Nome: {this.Nome}\nIdade: {this.Idade}";
        }


    }
}
