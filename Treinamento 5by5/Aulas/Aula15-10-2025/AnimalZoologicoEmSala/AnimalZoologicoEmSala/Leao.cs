using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoologicoEmSala
{
    public class Leao : Animal
    {
        public Leao(string nome, int idade) : base(nome, idade)
        {

        }

        public override string EmitirSom()
        {
            return "Roar Roar";
        }
    }
}
