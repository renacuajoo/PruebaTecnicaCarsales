namespace BackEnd.Models;

public class Episode
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string air_date { get; set; } = string.Empty;
    public string episodeCode { get; set; } = string.Empty;
    public string url { get; set; } = string.Empty;
}
