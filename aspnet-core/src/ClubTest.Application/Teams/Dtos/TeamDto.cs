using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ClubTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTest.Teams.Dtos
{
    [AutoMap(typeof(Team))]
    public class TeamDto: EntityDto
    {
        public string Name { get; set; }
    }
}
