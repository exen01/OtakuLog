using OtakuLog.Api.Enums;

namespace OtakuLog.Api.Entities;

/// <summary>
/// Represents the genre entity.
/// </summary>
public class Genre
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name in Latin.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Name in Russian.
    /// </summary>
    public required string Russian { get; set; }

    /// <summary>
    /// Media kind.
    /// </summary>
    public MediaKind MediaKind { get; set; }
}