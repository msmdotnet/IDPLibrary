namespace IDPLibrary.Entities.Interfaces;
public interface IUserProvider
{
    Task<bool> ValidateUserAsync(string userName, string password);
}
