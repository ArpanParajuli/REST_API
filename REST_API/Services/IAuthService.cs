namespace REST_API.Services
{
    public interface IAuthService
    {
       public Task<string> GenerateJwtToken(AuthUser user);
                        
    }
}
