class Diretor
{
    private List<Filme> filmes = new List<Filme>();

    public Diretor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarFilme(Filme filme) 
    { 
        filmes.Add(filme);
    }

    public void ExibirFilmografia()
    {
        Console.WriteLine($"Filmografia do diretor {Nome}");
        foreach (Filme filme in filmes)
        {
            Console.WriteLine($"Filme: {filme.Titulo} ({filme.Duracao} min)");
        }
    }
}
