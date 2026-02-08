using System.Security.Cryptography;
using System.Text;

namespace UrlShortener.Api.Services;

public class ShortCodeService : IShortCodeService
{
    public string Generate(string url)
    {
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(url));
        return Convert.ToBase64String(hash)
            .Replace("/", "_")
            .Replace("+", "-")
            .Substring(0, 8);
    }
}
