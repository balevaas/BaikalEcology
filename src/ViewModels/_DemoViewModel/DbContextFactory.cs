using BaseData.DataProviders.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _DemoViewModel;

public class DbContextFactory
{
    private readonly DbContextOptions _options;

    public DbContextFactory(DbContextOptions options) =>
        _options = options;

    public DataContext Create() => new(_options);
}