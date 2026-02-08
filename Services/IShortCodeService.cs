namespace UrlShortener.Api.Services;

public interface IShortCodeService
{
    string Generate(string url);
}
