
using A.Entities;

namespace A.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
        
    }
}