using Dotnetstore.WPF.Core.Interfaces;
using Dotnetstore.WPF.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnetstore.WPF.Core.IoC;

public static class ServiceCollectionBootStrap
{
    public static void Build(ref IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<ICultureService, CultureService>();
    }
}