using Microsoft.AspNetCore.Mvc;
using OtakuLog.Api.Abstract;
using OtakuLog.Api.Entities;
using OtakuLog.Api.Enums;
using System.Threading.Tasks;

namespace OtakuLog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimeController : ControllerBase
{
    private readonly IAnimeRepository _animeRepository;

    public AnimeController(IAnimeRepository animeRepository)
    {
        _animeRepository = animeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var animes = await _animeRepository.GetAllAsync();
        return Ok(animes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var anime = await _animeRepository.GetByIdAsync(id);
        if (anime is null)
            return NotFound();

        return Ok(anime);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Anime anime)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var createdAnime = await _animeRepository.CreateAsync(anime);
        return CreatedAtAction(nameof(GetById), new { createdAnime.Id }, createdAnime);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Anime anime)
    {
        if (id != anime.Id)
            return BadRequest();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updatedAnime = await _animeRepository.UpdateAsync(anime);
        return Ok(updatedAnime);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _animeRepository.DeleteAsync(id);
        if (!result)
            return NotFound();

        return Ok(result);
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchByTitle([FromQuery] string title)
    {
        var animes = await _animeRepository.SearchByTitleAsync(title);
        return Ok(animes);
    }

    [HttpGet("status/{status}")]
    public async Task<IActionResult> GetByStatus(AnimeStatus status)
    {
        var animes = await _animeRepository.GetByStatusAsync(status);
        return Ok(animes);
    }
}
