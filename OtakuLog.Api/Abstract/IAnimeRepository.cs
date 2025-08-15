using OtakuLog.Api.Entities;
using OtakuLog.Api.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OtakuLog.Api.Abstract;

/// <summary>
/// Interface for working with anime.
/// </summary>
public interface IAnimeRepository
{
    /// <summary>
    /// Getting all anime.
    /// </summary>
    /// <returns>List of all anime.</returns>
    Task<IEnumerable<Anime>> GetAllAsync();

    /// <summary>
    /// Getting anime by ID.
    /// </summary>
    /// <param name="id">Anime ID.</param>
    /// <returns>Found anime or <see langword="null"/>.</returns>
    Task<Anime?> GetByIdAsync(long id);

    /// <summary>
    /// Anime update.
    /// </summary>
    /// <param name="anime">Updated data.</param>
    /// <returns>Updated anime.</returns>
    Task<Anime> UpdateAsync(Anime anime);

    /// <summary>
    /// Delete anime by ID.
    /// </summary>
    /// <param name="id">Anime ID.</param>
    /// <returns><see langword="true"/> if the deletion was successful, otherwise <see langword="false"/>.</returns>
    Task<bool> DeleteAsync(long id);

    /// <summary>
    /// Creating a new anime.
    /// </summary>
    /// <param name="anime">Data.</param>
    /// <returns>Created anime.</returns>
    Task<Anime> CreateAsync(Anime anime);

    /// <summary>
    /// Search anime by title.
    /// </summary>
    /// <param name="title">Name of the anime.</param>
    /// <returns>List of found anime.</returns>
    Task<IEnumerable<Anime>> SearchByTitleAsync(string title);

    /// <summary>
    /// Search anime by genre.
    /// </summary>
    /// <param name="genre">Genre.</param>
    /// <returns>List of found anime.</returns>
    Task<IEnumerable<Anime>> GetByGenreAsync(Genre genre);

    /// <summary>
    /// Search anime by status.
    /// </summary>
    /// <param name="status">Status.</param>
    /// <returns>List of found anime.</returns>
    Task<IEnumerable<Anime>> GetByStatusAsync(AnimeStatus status);
}