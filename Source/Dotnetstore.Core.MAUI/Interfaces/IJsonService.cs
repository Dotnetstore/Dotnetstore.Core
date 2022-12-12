namespace Dotnetstore.Core.MAUI.Interfaces;

public interface IJsonService
{
    Task SaveAsync<T>(string file, T entity);

    void Save<T>(string file, T entity);

    Task<T> GetAsync<T>(string file);

    T Get<T>(string file);
}