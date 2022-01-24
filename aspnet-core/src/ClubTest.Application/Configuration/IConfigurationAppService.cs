using System.Threading.Tasks;
using ClubTest.Configuration.Dto;

namespace ClubTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
