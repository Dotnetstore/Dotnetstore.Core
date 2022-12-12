using Dotnetstore.Core.MAUI.Interfaces;
using Newtonsoft.Json;

namespace Dotnetstore.Core.MAUI.Services;

public sealed class JsonService : IJsonService
{
    T IJsonService.Get<T>(string file) where T : default
    {
        var json = File.ReadAllText(file);
        return JsonConvert.DeserializeObject<T>(json);
    }

    async Task<T> IJsonService.GetAsync<T>(string file) where T : default
    {
        var json = await File.ReadAllTextAsync(file);
        return JsonConvert.DeserializeObject<T>(json);
    }

    void IJsonService.Save<T>(string file, T entity)
    {
        File.WriteAllText(file, JsonConvert.SerializeObject(entity));
    }

    async Task IJsonService.SaveAsync<T>(string file, T entity)
    {
        await File.WriteAllTextAsync(file, JsonConvert.SerializeObject(entity));
    }
}