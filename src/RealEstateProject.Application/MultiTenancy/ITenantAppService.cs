using Abp.Application.Services;
using RealEstateProject.MultiTenancy.Dto;

namespace RealEstateProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

