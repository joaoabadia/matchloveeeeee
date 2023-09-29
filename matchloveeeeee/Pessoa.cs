using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matchloveeeeee
{
    internal class Pessoa
    {
    [Key]
    public string Nome;
        public int Id;
        public List<Mensagem> MensagensRecebidas = new List<Mensagem>();
        public List<Curtida> CurtidasRecebidas = new List<Curtida>();
        public List<Pessoa> Matches = new List<Pessoa>();

        public Pessoa(string nome, int id)
        {
            Nome = nome;
            Id = id;
        }

        public void EnviarMensagem(Pessoa destinatario, string mensagem)
        {
            if (Matches.Contains(destinatario))
            {
                Mensagem novaMensagem = new Mensagem(this, destinatario, mensagem);
                destinatario.MensagensRecebidas.Add(novaMensagem);
            }
            else
            {
                Console.WriteLine($"Você não pode enviar mensagens para {destinatario.Nome} sem um match.");
            }
        }

        public void FazerDenuncia(Mensagem mensagem, string motivo)
        {
            Denuncia denuncia = new Denuncia(this, mensagem.Remetente, motivo);
            // Adicione a denúncia a uma lista de denúncias pendentes
            // Implemente a lógica de denúncia aqui
        }

        public void Curtir(Pessoa pessoa)
        {
            Curtida curtida = new Curtida(this, pessoa);
            pessoa.CurtidasRecebidas.Add(curtida);
        }
    }
}

