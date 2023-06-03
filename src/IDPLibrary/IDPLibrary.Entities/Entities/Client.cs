namespace IDPLibrary.Entities.Entities;
public class Client
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string[] RedirectUris { get; set; }
}
