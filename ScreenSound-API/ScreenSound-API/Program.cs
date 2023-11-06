using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_API.Filtros;
using ScreenSound_API.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrasMusicasDeUmArtista(musicas, "Michael Jackson");


        //var musicasPreferidasDoEric = new MusicasPreferidas("Eric");
        //musicasPreferidasDoEric.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoEric.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoEric.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoEric.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoEric.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoEric.ExibirMusicasFavoritas();

        //var musicasPreferidasDaFernanda = new MusicasPreferidas("Fernanda");
        //musicasPreferidasDaFernanda.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasDaFernanda.AdicionarMusicasFavoritas(musicas[400]);
        //musicasPreferidasDaFernanda.AdicionarMusicasFavoritas(musicas[130]);
        //musicasPreferidasDaFernanda.AdicionarMusicasFavoritas(musicas[1800]);
        //musicasPreferidasDaFernanda.AdicionarMusicasFavoritas(musicas[1991]);

        //musicasPreferidasDaFernanda.ExibirMusicasFavoritas();

        //musicasPreferidasDaFernanda.GerarArquivoJson(); 

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema {ex.Message}");
    }
}