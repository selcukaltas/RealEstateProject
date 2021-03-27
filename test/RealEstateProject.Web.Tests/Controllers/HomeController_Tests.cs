using System.Threading.Tasks;
using RealEstateProject.Models.TokenAuth;
using RealEstateProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace RealEstateProject.Web.Tests.Controllers
{
    public class HomeController_Tests: RealEstateProjectWebTestBase
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