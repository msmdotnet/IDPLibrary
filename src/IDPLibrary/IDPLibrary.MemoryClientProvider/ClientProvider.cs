namespace IDPLibrary.MemoryClientProvider;
internal class ClientProvider : IClientProvider
{
    readonly IReadOnlyList<Client> Clients;
    public ClientProvider(IOptions<MemoryClientListOptions> options)
    {
        Clients = new List<Client>(options.Value.Clients);
    }

    public Task<Client> GetClientAsync(string clientId, string redirectUri)
    {
        Client Client = null;
        if(ClientIdAndRedirectUriHasValue(clientId, redirectUri))
        {
            Client = Clients.FirstOrDefault(c => c.ClientId == clientId && c.RedirectUris.Contains(redirectUri));
        }
        return Task.FromResult(Client);
    }

    bool ClientIdAndRedirectUriHasValue(string clientId, string redirectUri)
    {
        bool Result = !string.IsNullOrWhiteSpace(clientId) &&
                      !string.IsNullOrWhiteSpace(redirectUri);
        return Result;
    }
}
