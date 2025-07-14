namespace OtakuLog.Domain.Entities;

/// <summary>
/// Представляет аниме.
/// </summary>
public class Anime
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Название на латинице.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Название на русском.
    /// </summary>
    public required string Russian { get; set; }

    /// <summary>
    /// Количество эпизодов.
    /// </summary>
    public int Episodes { get; set; }

    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Жанры.
    /// </summary>
    public required Genre[] Genres { get; set; }
}
