namespace IDPLibrary.Endpoints;
internal class JwksEndpoint : IJwksEndpoint
{
    readonly IOptions<JwksOptions> Options;

    public JwksEndpoint(IOptions<JwksOptions> options)
    {
        Options = options;
    }

    public Task<IResult> GetJWKDocumentAsync() =>
        Task.FromResult(Results.Ok(Options.Value));

}
