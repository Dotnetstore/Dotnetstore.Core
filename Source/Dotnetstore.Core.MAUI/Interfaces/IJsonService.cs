namespace Dotnetstore.Core.MAUI.Interfaces;

public interface IJsonService
{
    Task SaveAsync<T>(string file, T entity);
}