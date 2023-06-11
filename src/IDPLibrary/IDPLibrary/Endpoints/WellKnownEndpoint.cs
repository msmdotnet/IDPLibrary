namespace IDPLibrary.Endpoints;
internal class WellKnownEndpoint : IWellKnownEndpoint
{
    // Send only required metadata
    public Task<IResult> GetConfigurationAsync(HttpContext context)
    {
        string Issuer = $"{context.Request.Scheme}://{context.Request.Host}";
        string UriBase = $"{Issuer}/oauth2";

        // https://openid.net/specs/openid-connect-discovery-1_0.html#ProviderMetadata
        Dictionary<string, object> Response = new()
        {
            { "issuer", Issuer },
            { "authorization_endpoint", $"{UriBase}/authorize" },
            { "token_endpoint", $"{UriBase}/token" },
            { "jwks_uri", $"{UriBase}/jwks" },
            { "response_types_supported", new string[] { "code" } }, // Only support code flow

            // http://openid.net/specs/openid-connect-core-1_0.html#SubjectIDTypes
            { "subject_types_supported", new string[] { "public", "pairwise" } },
            { "id_token_signing_alg_values_supported", new string[] { "RS256", "ES256", "HS256" } }
        };

        return Task.FromResult(Results.Ok(Response));
    }
}
