using OtakuLog.Api.Enums;

namespace OtakuLog.Api.Entities;

/// <summary>
/// Represents the entity of the user's anime watching progress.
/// </summary>
public class UserAnimeProgress
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id {  get; set; }

    /// <summary>
    /// User identifier.
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// Anime identifier.
    /// </summary>
    public long AnimeId { get; set; }

    /// <summary>
    /// Number of watched episodes.
    /// </summary>
    public int WatchedEpisodes { get; set; }

    /// <summary>
    /// Watch status.
    /// </summary>
    public WatchStatus WatchStatus { get; set; }

    /// <summary>
    /// User's score.
    /// </summary>
    public int? Score { get; set; }

    /// <summary>
    /// User's note.
    /// </summary>
    public string? Note {  get; set; }

    /// <summary>
    /// User.
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Anime.
    /// </summary>
    public Anime Anime { get; set; }
}