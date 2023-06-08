namespace IDPLibrary.MemoryClientProviderTests;

public class ClientProviderTests
{
    [Theory]
    [InlineData("client1", "https://localhost/callback", true)]
    [InlineData("client1", "https://localhost/callback2", false)]
    [InlineData("client2", "https://localhost/callback", false)]
    [InlineData("client2", "https://localhost/callback2", false)]
    public async void GetClientAsync_ExistingClient_ReturnClient(string clientId,
        string redirectUri, bool exists)
    {
        // Arrange
        var Clients = new Client[]
        {
            new Client
            {
                 ClientId = "client1",
                  ClientSecret = "clientsecret1",
                   RedirectUris = new string[]{"https://localhost/callback"}
            }
        };
        var ClientOptions = Options.Create(new MemoryClientListOptions { Clients = Clients});
        IClientProvider Provider = new ClientProvider(ClientOptions);

        // Act
        var Client = await Provider.GetClientAsync(clientId, redirectUri);

        // Assert        
        Assert.Equal(exists, Client!=null);
        if (exists)
        {
            Assert.Equal(clientId, Client.ClientId);
            Assert.Contains(redirectUri, Client.RedirectUris);
        }
    }
}