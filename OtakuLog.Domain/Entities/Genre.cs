using OtakuLog.Domain.Enums;

namespace OtakuLog.Domain.Entities;

/// <summary>
/// Представляет жанр.
/// </summary>
public class Genre
{
    /// <summary>
    /// Уникальный идентификатор.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название на латинице.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Название на русском.
    /// </summary>
    public string? Russian { get; set; }

    /// <summary>
    /// Тип медиа, к которому относится жанр.
    /// </summary>
    public MediaKind Kind { get; set; }
}
