namespace IDPLibrary.Entities.Interfaces;
public interface IStateService
{
    Task SetItemAsync<T>(string key, T value);
    Task<T> GetItemAsync<T>(string key);
    Task RemoveItemAsync(string key);
}
