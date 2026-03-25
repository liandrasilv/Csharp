class Filme
{
    public Filme(Diretor diretor, string titulo)
    {
        Diretor = diretor;
        Titulo = titulo;
    }

    public string Titulo { get; }
    public Diretor Diretor { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => 
        $"O filme {Titulo} foi dirigido por {Diretor.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Diretor: {Diretor.Nome}"); 
        Console.WriteLine($"Duração: {Duracao} min");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no catálogo.");
        } 
        else
        {
            Console.WriteLine("Filme indisponível. Assine o plano Premium.");
        }
    }
}
