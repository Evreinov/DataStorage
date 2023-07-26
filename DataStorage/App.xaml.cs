using System;
using DataStorage.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataStorage;

public partial class App
{
    private static IServiceProvider? _services;

    private static IConfiguration? _configuration;

    public static IServiceProvider Services => _services ??= GetServices().BuildServiceProvider();

    public static IConfiguration Configuration => _configuration ??= Configure().Build();

    private static IServiceCollection GetServices()
    {
        var services = new ServiceCollection();
        InitializeServices(services);
        return services;
    }

    private static IConfigurationBuilder Configure()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("");
        return config;
    }

    private static void InitializeServices(IServiceCollection services)
    {
        services.AddSingleton<MainWindowViewModel>();
    }
}