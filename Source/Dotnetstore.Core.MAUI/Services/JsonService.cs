using Dotnetstore.Core.MAUI.Interfaces;
using Newtonsoft.Json;

namespace Dotnetstore.Core.MAUI.Services;

public sealed class JsonService : IJsonService
{
    async Task IJsonService.SaveAsync<T>(string file, T entity)
    {
        await File.WriteAllTextAsync(file, JsonConvert.SerializeObject(entity));
    }
}