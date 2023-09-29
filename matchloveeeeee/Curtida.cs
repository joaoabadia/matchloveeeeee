using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchloveeeeee
{
    internal class Curtida
    {
        public Pessoa Remetente;
        public Pessoa Destinatario;
        public DateTime DataHora;

        public Curtida(Pessoa remetente, Pessoa destinatario)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            DataHora = DateTime.Now;
        }
    }
}

