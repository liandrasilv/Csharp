class Filme
{
    private List<Cena> cenas = new List<Cena>();

    public Filme(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => cenas.Sum(c => c.Duracao);

    public void AdicionarCena(Cena cena)
    {
        cenas.Add(cena);
    }

    public void ExibirCenasDoFilme()
    {
        Console.WriteLine($"Exibindo capítulos/cenas do filme: {Nome}\n");
        foreach (var cena in cenas)
        {
            Console.WriteLine($"Cena: {cena.Nome}");
        }
        Console.WriteLine($"\nDuração total da obra: {DuracaoTotal} minutos.");
    }
}
