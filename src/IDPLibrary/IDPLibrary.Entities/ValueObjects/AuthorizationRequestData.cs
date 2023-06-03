namespace IDPLibrary.Entities.ValueObjects;
public class AuthorizationRequestData
{
    public string State { get; set; }
    public string RedirectUri { get; set; }
    public string ClientId { get; set; }
    public string Code { get; set; }
    public string CodeChallenge { get; set; }
    public string CodeChallengeMethod { get; set; }
    public string Nonce { get; set; }
    public string Scope { get; set; }
}
