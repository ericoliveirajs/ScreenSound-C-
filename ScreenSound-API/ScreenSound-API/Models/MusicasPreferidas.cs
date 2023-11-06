using ScreenSound_04.Modelos;
using System.Text.Json;

namespace ScreenSound_API.Models;

internal class MusicasPreferidas
{
    public string? Nome { get; }
    public List<Musica> ListaDeMusicasFavoritas;

    public MusicasPreferidas(string nome) {

        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas {Nome}");
        foreach (var musica  in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
            Console.WriteLine();
    }

    public void GerarArquivoJson ()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string nomeDoArquivo = $"Musicas favoritas - {Nome}.json";  
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo JSON foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
