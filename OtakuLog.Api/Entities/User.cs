using System.Collections.Generic;

namespace OtakuLog.Api.Entities;

/// <summary>
/// Represents the user entity.
/// </summary>
public class User
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// User name.
    /// </summary>
    public required string Username { get; set; }

    /// <summary>
    /// Email.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// User anime progress list.
    /// </summary>
    public ICollection<UserAnimeProgress> AnimeProgressList { get; set; } = [];
}
