namespace IDPLibrary.Entities.Options;
public class JwksOptions
{
    public const string SectionKey = "jwks_keys";

    [JsonPropertyName("keys")]
    public Jwk[] Keys { get; set; }
}
