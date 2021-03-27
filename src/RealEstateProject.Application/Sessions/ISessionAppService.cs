using System.Threading.Tasks;
using Abp.Application.Services;
using RealEstateProject.Sessions.Dto;

namespace RealEstateProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
