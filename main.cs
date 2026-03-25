string mensagemDeBoasVindas = "Bem-vindo ao Screen Movie - Seu Letterboxd no Console";
Dictionary<string, List<int>> filmesRegistrados = new Dictionary<string, List<int>>();

filmesRegistrados.Add("Pulp Fiction", new List<int> { 10, 9, 10 });
filmesRegistrados.Add("Parasita", new List<int> { 10, 10, 8 });
filmesRegistrados.Add("Madame Teia", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ███╗░░░███╗░█████╗░██╗░░░██╗██╗███████╗
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ████╗░████║██╔══██╗██║░░░██║██║██╔════╝
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ██╔████╔██║██║░░██║╚██╗░██╔╝██║█████╗░░
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ██║╚██╔╝██║██║░░██║░╚████╔╝░██║██╔══╝░░
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██║░╚═╝░██║╚█████╔╝░░╚██╔╝░░██║███████╗
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═╝░░░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝╚══════╝
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n[1] Registrar um novo filme");
    Console.WriteLine("[2] Listar catálogo de filmes");
    Console.WriteLine("[3] Avaliar um filme (0-10)");
    Console.WriteLine("[4] Ver média de avaliações");
    Console.WriteLine("[-1] Sair");

    Console.Write("\nEscolha sua ação: ");
    string opcaoEscolhida = Console.ReadLine()!;
    
    if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
    {
        switch (opcaoEscolhidaNumerica)
        {
            case 1: RegistrarFilme(); break;
            case 2: MostrarFilmesRegistrados(); break;
            case 3: AvaliarUmFilme(); break;
            case 4: ExibirMediaDoFilme(); break;
            case -1: Console.WriteLine("Até a próxima sessão! :)"); break;
            default: Console.WriteLine("Opção inválida."); break;
        }
    }
}

void RegistrarFilme()
{
    Console.Clear();
    ExibirTituloDaOpcao("🎬 Registro de Filmes");
    Console.Write("Digite o título do filme: ");
    string nomeDoFilme = Console.ReadLine()!;
    filmesRegistrados.Add(nomeDoFilme, new List<int>());
    Console.WriteLine($"\nO filme '{nomeDoFilme}' foi adicionado ao catálogo!");
    Thread.Sleep(2500);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarFilmesRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("🍿 Catálogo Screen Movie");
    foreach (string filme in filmesRegistrados.Keys)
    {
        Console.WriteLine($"• {filme}");
    }

    Console.WriteLine("\nPresione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmFilme()
{
    Console.Clear();
    ExibirTituloDaOpcao("⭐ Avaliar Filme");
    Console.Write("Qual filme você deseja avaliar? ");
    string nomeDoFilme = Console.ReadLine()!;
    
    if (filmesRegistrados.ContainsKey(nomeDoFilme))
    {
        Console.Write($"Que nota você dá para '{nomeDoFilme}' (0 a 10): ");
        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            filmesRegistrados[nomeDoFilme].Add(nota);
            Console.WriteLine($"\nSua avaliação de {nota} estrelas foi salva!");
        }
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO filme '{nomeDoFilme}' não foi encontrado no nosso banco de dados.");
        Console.WriteLine("Pressione uma tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDoFilme()
{
    Console.Clear();
    ExibirTituloDaOpcao("📊 Média Crítica");
    Console.Write("Digite o nome do filme: ");
    string nomeDoFilme = Console.ReadLine()!;
    
    if (filmesRegistrados.ContainsKey(nomeDoFilme))
    {
        List<int> notas = filmesRegistrados[nomeDoFilme];
        if (notas.Count > 0)
        {
            Console.WriteLine($"\nA média de '{nomeDoFilme}' é: {notas.Average():F1}");
        }
        else
        {
            Console.WriteLine($"\nO filme '{nomeDoFilme}' ainda não possui avaliações.");
        }
        
        Console.WriteLine("\nPressione uma tecla para voltar.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nFilme '{nomeDoFilme}' não localizado.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string linha = new string('=', quantidadeDeLetras);
    Console.WriteLine(linha);
    Console.WriteLine(titulo);
    Console.WriteLine(linha + "\n");
}

ExibirOpcoesDoMenu();
