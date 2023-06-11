namespace IDPLibrary.Entities.ValueObjects;

// https://datatracker.ietf.org/doc/html/rfc7517#section-4
public class Jwk
{
    [JsonPropertyName("kty")]
    public string Kty { get; set; }

    [JsonPropertyName("use")]
    public string Use { get; set; }

    [JsonPropertyName("alg")]
    public string Alg { get; set; }

    [JsonPropertyName("kid")]
    public string Kid { get; set; }

    // https://datatracker.ietf.org/doc/html/rfc7517#section-9.3
    // https://www.rfc-editor.org/rfc/rfc7518#section-6.3

    [JsonPropertyName("e")]
    public string E { get; set; }

    [JsonPropertyName("n")]
    public string N { get; set; }
}
