using BackEnd.Clients;
using BackEnd.Models;

namespace BackEnd.Services;

public interface IEpisodesService
{
    Task<EpisodesResponse> GetEpisodesAsync(int page);
}

public class EpisodesService : IEpisodesService
{
    private readonly IRickAndMortyClient _client;

    public EpisodesService(IRickAndMortyClient client)
    {
        _client = client;
    }

    public async Task<EpisodesResponse> GetEpisodesAsync(int page)
    {
        if (page <= 0)
            throw new ArgumentException("Página debe ser mayor que 0");

        return await _client.GetEpisodesAsync(page);
    }
}
