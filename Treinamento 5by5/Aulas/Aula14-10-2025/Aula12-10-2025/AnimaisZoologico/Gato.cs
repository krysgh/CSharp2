using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimaisZoologico
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("MIAU MIAU");
        }
    }
}
