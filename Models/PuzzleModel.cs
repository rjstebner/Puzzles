namespace Puzzles;

/// <summary>
/// Represents a pre-configured template for a pizza a user can order
/// </summary>
public class PuzzleList
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal BasePrice { get; set; }

    public string? Description { get; set; }

    public int? Difficulty { get; set; }

    public string? ImageUrl { get; set; }

    public string? GetFormattedBasePrice() => BasePrice.ToString("C");
}