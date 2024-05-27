using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class GiphyController : ControllerBase
{
    private readonly GiphyService _giphyService;

    public GiphyController(GiphyService giphyService)
    {
        _giphyService = giphyService;
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchGifs(string query)
    {
        var result = await _giphyService.SearchGifsAsync(query);
        return Ok(result);
    }
}
