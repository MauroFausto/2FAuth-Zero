using _2FA_Zero.Interfaces;

namespace _2FA_Zero.Repository
{
    public abstract class SecurityRepository : BaseRepository
    {
        public string? ServiceSecurityToken { get; }

        
    }
}
