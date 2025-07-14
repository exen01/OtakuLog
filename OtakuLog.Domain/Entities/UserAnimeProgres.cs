using OtakuLog.Domain.Enums;

namespace OtakuLog.Domain.Entities;

/// <summary>
/// Запись в аниме списке пользователя.
/// </summary>
public class UserAnimeProgres
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентифкатор аниме.
    /// </summary>
    public long AnimeId { get; set; }

    /// <summary>
    /// Количество просмотренных эпизодов.
    /// </summary>
    public int WatchedEpisodes { get; set; }

    /// <summary>
    /// Статус просмотра.
    /// </summary>
    public WatchStatus Status { get; set; }

    /// <summary>
    /// Оценка.
    /// </summary>
    public int Rating { get; set; }

    /// <summary>
    /// Пользователь.
    /// </summary>
    public User User { get; set; }

    /// <summary>
    /// Аниме.
    /// </summary>
    public Anime Anime { get; set; }
}
