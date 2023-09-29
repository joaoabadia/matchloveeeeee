using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchloveeeeee
{
    internal class Mensagem
    {
        public Pessoa Remetente;
        public Pessoa Destinatario;
        public string Conteudo;
        public DateTime DataHora;

        public Mensagem(Pessoa remetente, Pessoa destinatario, string conteudo)
        {
            Remetente = remetente;
            Destinatario = destinatario;
            Conteudo = conteudo;
            DataHora = DateTime.Now;
        }
    }
}
