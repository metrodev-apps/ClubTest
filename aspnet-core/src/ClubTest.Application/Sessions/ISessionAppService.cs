using System.Threading.Tasks;
using Abp.Application.Services;
using ClubTest.Sessions.Dto;

namespace ClubTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
