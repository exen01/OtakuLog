using System.Collections.Generic;

namespace OtakuLog.Api.Entities;

/// <summary>
/// Presents an Anime entity.
/// </summary>
public class Anime
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Name in Latin.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Name in Russian.
    /// </summary>
    public required string Russian { get; set; }

    /// <summary>
    /// Number of episodes.
    /// </summary>
    public int Episodes { get; set; }

    /// <summary>
    /// Description text.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// List of genres.
    /// </summary>
    public required ICollection<Genre> Genres { get; set; }
}
