Banda legiaoUrbana = new Banda("Legião Urbana");

Album albumLegiaoUrbana = new Album("Que País É Esse?");

Musica musica1 = new Musica(legiaoUrbana, "Que País é Este?")
{
    Duracao = 179,
    Disponivel = true,
};

Musica musica2 = new Musica(legiaoUrbana, "Angra dos Reis")
{
    Duracao = 290,
    Disponivel = false,
};

musica2.Duracao = 290;

albumLegiaoUrbana.AdicionarMusica(musica1);
albumLegiaoUrbana.AdicionarMusica(musica2);
legiaoUrbana.AdicionarAlbum (albumLegiaoUrbana);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica ();
//legiaoUrbana.ExibirDiscografia();
//albumLegiaoUrbana.ExibirMusicasDoAlbum();

Podcast naoInviabilize = new Podcast("Não inviabilize");
QuadroPodcast quadro = new QuadroPodcast("Picolé de Limão");

Episodio episodio1 = new Episodio(naoInviabilize, "Cunhado")
{
    Duracao = 23,
    Resumo = "Esse episódio contém conteúdo sensível, ouça com cautela"
};

episodio1.ExibirDetalhes();
