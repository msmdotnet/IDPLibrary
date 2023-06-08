namespace IDPLibrary.MemoryCacheState;
public class MemoryCacheStateService : IStateService
{
    readonly IMemoryCache CacheMemory;
    public MemoryCacheStateService(IMemoryCache cacheMemory)
    {
        CacheMemory = cacheMemory;
    }

    public Task<T> GetItemAsync<T>(string key)
    {
        CacheMemory.TryGetValue(key, out T statevalue);
        return Task.FromResult(statevalue);
    }

    public Task RemoveItemAsync(string key)
    {
        CacheMemory.Remove(key);
        return Task.CompletedTask;
    }

    public Task SetItemAsync<T>(string key, T value)
    {
        if (!CacheMemory.TryGetValue(key, out string _))
        {
            CacheMemory.Set(key, value, DateTime.Now.AddMinutes(8));
        }
        return Task.CompletedTask;
    }


}