namespace IDPLibrary;
public static class DependencyContainer
{
    public static IServiceCollection AddIDPLibraryCoreServices(this IServiceCollection services,
        Action<JwksOptions> jwksOptionsSetter)
    {
        services.TryAddSingleton<IWellKnownEndpoint, WellKnownEndpoint>();

        services.Configure<JwksOptions>(options => jwksOptionsSetter(options));
        services.TryAddSingleton<IJwksEndpoint, JwksEndpoint>();

        return services;
    }

    public static IServiceCollection AddIDPLibraryServices(this IServiceCollection services,
        Action<JwksOptions> jwksOptionsSetter)
    {
        services.AddIDPLibraryCoreServices(jwksOptionsSetter);

        return services;
    }

    public static WebApplication UseIDPLibraryEndpoints(this WebApplication app)
    {
        app.MapGet("/.well-known/openid-configuration",
            async (HttpContext context, IWellKnownEndpoint endpoint) =>
                await endpoint.GetConfigurationAsync(context));

        app.MapGet("/oauth2/jwks",
            async (IJwksEndpoint endpoint) =>
                await endpoint.GetJWKDocumentAsync());

        return app;
    }
}

