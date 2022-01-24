using ClubTest.Teams.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTest.Teams
{
    public class TeamAppService : ClubTestAppServiceBase, ITeamAppService
    {
        public Task Create(TeamDto team)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeamDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TeamDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(TeamDto team)
        {
            throw new NotImplementedException();
        }
    }
}
