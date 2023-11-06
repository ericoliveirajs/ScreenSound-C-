class Episodio
{
    public Episodio(Podcast nome, string titulo)
    {
        Podcast = nome;
        Titulo = titulo;
    }

    public Podcast Podcast { get; }
    public string Titulo { get; }
    public string Ordem { get; set; }
    public string Resumo { get; set; }
    public int Duracao { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do episódio: {Titulo}");
        Console.WriteLine($"Ordem: {Ordem}");
        Console.WriteLine($"Resumo: {Resumo}");
        Console.WriteLine($"Duração do Episódio: {Duracao}");
    }

}