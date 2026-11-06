using SenacStore.Domain.Entities;

namespace SenacStore.Application.Interfaces
{
    public interface IAuthService
    {
        Task<Usuario> LoginAsync(string email, string senha);

        void Logout();
    }
}
