using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotificacoes
{
    public class Email: Notificacao
    {

        public override void Enviar()
        {
            Console.WriteLine("Estou mandando um Email.");
        }
    }
}
