namespace IDPLibrary.MemoryCacheState;

public static class DependendencyContainer
{
    public static IServiceCollection AddMemoryCacheStateServices(
        this IServiceCollection services)
    {
        services.TryAddSingleton<IMemoryCache, MemoryCache>();
        services.TryAddSingleton<IStateService, MemoryCacheStateService>();

        return services;
    }
}