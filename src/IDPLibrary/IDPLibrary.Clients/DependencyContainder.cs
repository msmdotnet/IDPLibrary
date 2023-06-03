namespace IDPLibrary.Clients;

public static class DependencyContainder
{
    public static IServiceCollection AddClientServices(this IServiceCollection services, IConfiguration configuration, string clientsKey = "")
    {
        services.Configure<ClientList>(configuration.GetSection(string.IsNullOrWhiteSpace(clientsKey) ? ClientList.SectionKey : clientsKey));

        services.AddScoped<IClientProvider, ClientProvider>();

        return services;
    }
}
