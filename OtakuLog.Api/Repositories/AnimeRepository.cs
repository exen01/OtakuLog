using Microsoft.EntityFrameworkCore;
using OtakuLog.Api.Abstract;
using OtakuLog.Api.Entities;
using OtakuLog.Api.Enums;
using OtakuLog.Api.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtakuLog.Api.Repositories;

public class AnimeRepository : IAnimeRepository
{
    /// <summary>
    /// Database context.
    /// </summary>
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="applicationDbContext">Database context.</param>
    public AnimeRepository(ApplicationDbContext applicationDbContext)
    {
        this._context = applicationDbContext;
    }

    /// <inheritdoc/>
    public async Task<Anime> CreateAsync(Anime anime)
    {
        _context.Animes.Add(anime);
        await _context.SaveChangesAsync();
        return anime;
    }

    /// <inheritdoc/>
    public async Task<bool> DeleteAsync(long id)
    {
        var anime = await _context.Animes.FirstOrDefaultAsync(a => a.Id == id);
        if (anime is null)
            return false;

        _context.Animes.Remove(anime);
        await _context.SaveChangesAsync();
        return true;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Anime>> GetAllAsync()
    {
        return await _context.Animes.ToListAsync();
    }

    /// <inheritdoc/>
    public async Task<Anime> UpdateAsync(Anime anime)
    {
        _context.Animes.Update(anime);
        await _context.SaveChangesAsync();
        return anime;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Anime>> GetByGenreAsync(Genre genre)
    {
        return await _context.Animes
            .Where(a => a.Genres.Contains(genre))
            .ToListAsync();
    }

    /// <inheritdoc/>
    public Task<Anime?> GetByIdAsync(long id)
    {
        return _context.Animes.FirstOrDefaultAsync(a => a.Id == id);
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Anime>> GetByStatusAsync(AnimeStatus status)
    {
        return await _context.Animes
            .Where(a => a.AnimeStatus == status)
            .ToListAsync();
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Anime>> SearchByTitleAsync(string title)
    {
        return await _context.Animes
            .Where(a => a.Name.Contains(title) || a.Russian.Contains(title))
            .ToListAsync();
    }
}