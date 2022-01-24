using System.Threading.Tasks;
using Abp.Application.Services;
using ClubTest.Authorization.Accounts.Dto;

namespace ClubTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
