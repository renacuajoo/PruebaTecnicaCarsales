using BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers;

[ApiController]
[Route("api/episodes")]
public class EpisodesController : ControllerBase
{
    private readonly IEpisodesService _service;

    public EpisodesController(IEpisodesService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetEpisodes([FromQuery] int page = 1)
    {
        var data = await _service.GetEpisodesAsync(page);
        return Ok(data);
    }
}
