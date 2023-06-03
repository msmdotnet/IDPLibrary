namespace IDPLibrary.Clients.Specifications;
internal class ClientSpecification
{
    readonly string ClientId;
    readonly string RedirectUir;

    public ClientSpecification(string clientId, string redirectUir)
    {
        ClientId = clientId;
        RedirectUir = redirectUir;
    }

    public bool IsValidated()
    {
        bool result;
        result = string.IsNullOrWhiteSpace(ClientId);
        result = string.IsNullOrWhiteSpace(RedirectUir);
        return result;
    }
}
