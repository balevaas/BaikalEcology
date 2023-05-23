using Microsoft.EntityFrameworkCore;

namespace BaseData.DataProviders.EntityFramework.Contexts;

public class DbContextFactory
{
    private readonly DbContextOptions _options;

    public DbContextFactory(DbContextOptions options) =>
        _options = options;

    public DataContext Create() => new(_options);
}