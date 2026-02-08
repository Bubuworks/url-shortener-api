namespace UrlShortener.Api.Data;

public class UrlMapping
{
    public int Id { get; set; }
    public string OriginalUrl { get; set; } = null!;
    public string ShortCode { get; set; } = null!;
    public int Clicks { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastAccessedAt { get; set; }
}
