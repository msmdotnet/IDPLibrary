namespace IDPLibrary.Entities.Interfaces.Endpoints;
public interface IWellKnownEndpoint
{
    Task<IResult> GetConfigurationAsync(HttpContext context);
}
