using Abp.Application.Services;
using ClubTest.MultiTenancy.Dto;

namespace ClubTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

