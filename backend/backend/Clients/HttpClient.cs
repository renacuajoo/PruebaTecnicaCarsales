using BackEnd.Models;
using System.Net.Http.Json;

namespace BackEnd.Clients;

public interface IRickAndMortyClient
{
    Task<EpisodesResponse> GetEpisodesAsync(int page);
}

public class RickAndMortyClient : IRickAndMortyClient
{
    private readonly HttpClient _http;

    public RickAndMortyClient(HttpClient http)
    {
        _http = http;
    }

    public async Task<EpisodesResponse> GetEpisodesAsync(int page)
    {
        var url = $"https://rickandmortyapi.com/api/episode?page={page}";
        var response = await _http.GetAsync(url);

        if (!response.IsSuccessStatusCode)
            throw new Exception($"Error al consumir Rick & Morty: {response.StatusCode}");

        return await response.Content.ReadFromJsonAsync<EpisodesResponse>()
               ?? throw new Exception("Respuesta inválida de la API");
    }
}
