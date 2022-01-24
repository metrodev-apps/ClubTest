using Abp.Application.Services;
using ClubTest.Teams.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubTest.Teams
{
    public interface ITeamAppService: IApplicationService
    {
        List<TeamDto> GetAll();
        Task<TeamDto> Get(int id);
        Task Create(TeamDto team);
        Task Update(TeamDto team);
        Task Delete(int id);
    }
}