class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }

    public string Host { get; set; }
    public int TotalDeEpisodios { get; set; }
 




}