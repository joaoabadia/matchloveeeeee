using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchloveeeeee
{
    internal class Denuncia
    {
        public Pessoa Denunciante;
        public Pessoa Denunciado;
        public string Motivo;

        public Denuncia(Pessoa denunciante, Pessoa denunciado, string motivo)
        {
            Denunciante = denunciante;
            Denunciado = denunciado;
            Motivo = motivo;
        }
    }
}
