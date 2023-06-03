namespace IDPLibrary.Entities.Interfaces;
public interface IClientProvider
{
    Task<Client> GetClientAsync(string clientId, string redirectUri);

}
