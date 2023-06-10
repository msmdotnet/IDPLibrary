using IDPLibrary.Entities.ValueObjects;
namespace IDPLibrary.Entities.Interfaces.Endpoints;
public interface IDiscoveryEndpointService
{
    Task<ConfigurationResponse> GetConfigurationAsync();
}
