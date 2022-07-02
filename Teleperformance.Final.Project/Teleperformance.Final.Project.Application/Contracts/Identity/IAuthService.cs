using Teleperformance.Final.Project.Application.Models.Identity;

namespace Teleperformance.Final.Project.Application.Contracts.Identity
{
    public interface IAuthService
    {

        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);

    }
}
