using Abp.Domain.Repositories;
using ClubTest.Domain;
using ClubTest.Teams.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTest.Teams
{
    public class TeamAppService : ClubTestAppServiceBase, ITeamAppService
    {
        private readonly IRepository<Team> _teamRepository;

        public TeamAppService(IRepository<Team> teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task Create(TeamDto team)
        {
            var teamData = ObjectMapper.Map<Team>(team);
            await _teamRepository.InsertAsync(teamData);
        }

        public async Task Delete(int id)
        {
            var team = await _teamRepository.FirstOrDefaultAsync(id);
            if (team != null)
            {
                await _teamRepository.DeleteAsync(team);
            }
        }

        public async Task<TeamDto> Get(int id)
        {
            var team = await _teamRepository.FirstOrDefaultAsync(id);
            var result = ObjectMapper.Map<TeamDto>(team);
            return result;
        }

        public List<TeamDto> GetAll()
        {
            var teams = _teamRepository.GetAll().Select(x => ObjectMapper.Map<TeamDto>(x)).ToList();
            return teams;
        }

        public async Task Update(TeamDto team)
        {
            var teamData = await _teamRepository.FirstOrDefaultAsync(team.Id);
            if (teamData != null)
            {
                teamData = ObjectMapper.Map(team, teamData);
                await _teamRepository.UpdateAsync(teamData);
            }
        }
    }
}
