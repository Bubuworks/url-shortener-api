using Microsoft.EntityFrameworkCore;

namespace UrlShortener.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<UrlMapping> UrlMappings => Set<UrlMapping>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
