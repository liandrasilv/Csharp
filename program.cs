Diretor tarantino = new Diretor("Quentin Tarantino");

Filme pulpFiction = new Filme("Pulp Fiction");

Cena cena1 = new Cena(tarantino, "Misirlou - Opening Credits")
{
    Duracao = 150,
    DisponivelNoCorteFinal = true,
};

Cena cena2 = new Cena(tarantino, "The 5-Dollar Shake")
{
    Duracao = 240,
    DisponivelNoCorteFinal = true,
};

pulpFiction.AdicionarCena(cena1);
pulpFiction.AdicionarCena(cena2);
tarantino.AdicionarFilme(pulpFiction);

cena1.ExibirFichaTecnica();
cena2.ExibirFichaTecnica();
pulpFiction.ExibirCenasDoFilme();
tarantino.ExibirFilmografia();
