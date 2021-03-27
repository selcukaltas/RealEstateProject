using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RealEstateProject.Configuration.Dto;

namespace RealEstateProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RealEstateProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
