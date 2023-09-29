using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchloveeeeee
{
    internal class Match
    {
        public Pessoa Pessoa1;
        public Pessoa Pessoa2;

        public Match(Pessoa pessoa1, Pessoa pessoa2)
        {
            Pessoa1 = pessoa1;
            Pessoa2 = pessoa2;
        }

        public bool VerificarMatch()
        {
            bool curtidaPessoa1ParaPessoa2 = Pessoa1.CurtidasRecebidas.Exists(curtida => curtida.Remetente == Pessoa2);
            bool curtidaPessoa2ParaPessoa1 = Pessoa2.CurtidasRecebidas.Exists(curtida => curtida.Remetente == Pessoa1);

            if (curtidaPessoa1ParaPessoa2 && curtidaPessoa2ParaPessoa1)
            {
                Console.WriteLine($"{Pessoa1.Nome} e {Pessoa2.Nome} deram match!");
                Pessoa1.Matches.Add(Pessoa2);
                Pessoa2.Matches.Add(Pessoa1);
                return true;
            }
            return false;
        }
    }
}
