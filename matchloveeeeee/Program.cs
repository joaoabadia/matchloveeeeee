using matchloveeeeee;
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Alice", 1);
        Pessoa pessoa2 = new Pessoa("Bob", 2);
        
        pessoa1.Curtir(pessoa2);
        pessoa2.Curtir(pessoa1);

        // Verificar match
        Match match = new Match(pessoa1, pessoa2);
        match.VerificarMatch();

        // Alice tenta enviar uma mensagem para Bob
        pessoa1.EnviarMensagem(pessoa2, "Oi, Bob!");

        // Lógica para exibir mensagens, matches, denúncias, etc.
        foreach (var mensagem in pessoa2.MensagensRecebidas)
        {
            Console.WriteLine($"{mensagem.Remetente.Nome}: {mensagem.Conteudo}");
        }

        Console.ReadKey();
    }
}