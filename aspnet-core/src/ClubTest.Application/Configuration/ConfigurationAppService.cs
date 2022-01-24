using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ClubTest.Configuration.Dto;

namespace ClubTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ClubTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
