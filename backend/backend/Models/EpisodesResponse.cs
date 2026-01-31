namespace BackEnd.Models;

public class EpisodesResponse
{
    public Info Info { get; set; } = new();
    public List<Episode> Results { get; set; } = new();
}

public class Info
{
    public int Count { get; set; }
    public int Pages { get; set; }
    public string? Next { get; set; }
    public string? Prev { get; set; }
}
