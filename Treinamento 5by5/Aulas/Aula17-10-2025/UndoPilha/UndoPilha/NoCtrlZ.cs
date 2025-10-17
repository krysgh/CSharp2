using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoPilha
{
    public class NoCtrlZ
    {
        public string texto {  get; set; }

        public NoCtrlZ Proximo { get; set; }

        public NoCtrlZ(string texto)
        {
            this.texto = texto;
            this.Proximo = null;
        }

        public override string ToString()
        {
            return $"Texto: {this.texto}";
        }

    }
}
