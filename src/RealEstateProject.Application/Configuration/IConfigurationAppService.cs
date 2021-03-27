using System.Threading.Tasks;
using RealEstateProject.Configuration.Dto;

namespace RealEstateProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
