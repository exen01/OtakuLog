namespace OtakuLog.Domain.Entities;

/// <summary>
/// Представляет пользователя.
/// </summary>
public class User
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public required string Username { get; set; }

    /// <summary>
    /// Электронная почта.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// Список аниме пользователя.
    /// </summary>
    public ICollection<UserAnimeProgres> AnimeProgresList { get; set; } = [];
}
