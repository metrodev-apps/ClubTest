using System.Threading.Tasks;
using ClubTest.Models.TokenAuth;
using ClubTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace ClubTest.Web.Tests.Controllers
{
    public class HomeController_Tests: ClubTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}