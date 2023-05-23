using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace ConnectionConfig;

public static class ConnectionStrings
{
    public const string
        Sqlite = "Sqlite",
        SqlExpress = "SqlExpress";

    public static string GetConnectionStrings(string key)
    {
        // Получить поток ресурса по имени файла
        var assembly = Assembly.GetExecutingAssembly();
        var resourceStream = assembly.GetManifestResourceStream("ConnectionConfig.appsettings.json");

        var builder = new ConfigurationBuilder();

        // получаем конфигурацию из файла appsettings.json
        builder.AddJsonStream(resourceStream!);
        // создаем конфигурацию
        var config = builder.Build();

        // получаем строку подключения
        var connectionString = config.GetConnectionString(key);

        return connectionString ?? throw new ArgumentException($"Такой строки подключения не существует: {key}", key);
    }
}